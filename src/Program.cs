using Scalar.AspNetCore;
using NLog;
using DotNetEnv;
using src.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using src;
using Domain.Entities.ErrorModel;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);
// Load environment variables from the .env file
Env.Load();

// Set up NLog
var nLogConfigFilePath = string.Concat(Directory.GetCurrentDirectory(), "\\nlog.config");
LogManager.Setup().LoadConfigurationFromFile(nLogConfigFilePath);

// Add services to the container.

// enable cors
builder.Services.ConfigureCors();
// auto mapper
builder.Services.AddAutoMapper(typeof(MappingProfile));
// enable db context
builder.Services.InjectDbContext();
// enable identity
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT();
// add logger service
builder.Services.ConfigureLoggerService();
// handle global exception
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
// inject services
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();



builder.Services.AddControllers()
                .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
                .ConfigureApiBehaviorOptions(options =>
                {
                    // options.SuppressModelStateInvalidFilter = true;
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        // Console.WriteLine("Invoked");
                        var errors = context.ModelState
                            .Where(ms => ms.Value?.Errors.Count > 0)
                            .ToDictionary(
                                kvp => kvp.Key,
                                kvp => kvp.Value?.Errors.Select(e => e.ErrorMessage).ToList() ?? new List<string>()
                            );

                        var errorDetails = new ErrorDetails
                        {
                            StatusCode = 400,
                            Message = "One or more validation errors occurred.",
                            Errors = errors
                        };

                        return new BadRequestObjectResult(errorDetails);
                    };

                });
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services.AddOpenApi("v1", options => { options.AddDocumentTransformer<BearerSecuritySchemeTransformer>(); });

var app = builder.Build();

// apply migrations
app.ApplyMigrations();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment()){ }
app.MapOpenApi();
app.MapScalarApiReference(options =>
{
    options.WithTitle("First APi");
    options.WithTheme(ScalarTheme.DeepSpace);
    options.WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.Axios);
    options.WithModels(false);

});
if (app.Environment.IsProduction())
    app.UseHsts();

app.UseHttpsRedirection();
// use custom cors middleware
app.UseCors("CorsPolicy");
// use global exception handler
app.UseExceptionHandler(opt => { });
app.UseStaticFiles();//new
app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.All });//new
app.UseAuthentication();//new; must be before authorization
app.UseAuthorization();
app.MapControllers();

app.Run();

using Scalar.AspNetCore;
using NLog;
using DotNetEnv;
using src.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using src;
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
// add logger service
builder.Services.ConfigureLoggerService();
// inject services
builder.Services.ConfigureServiceManager();



builder.Services.AddControllers()
                .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);//new
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

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
    options.OperationSorter = OperationSorter.Method;

    //...
});
if (app.Environment.IsProduction())
    app.UseHsts();

app.UseHttpsRedirection();
// use custom cors middleware
app.UseCors("CorsPolicy");
app.UseStaticFiles();//new
app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.All });//new
app.UseAuthentication();//new
app.UseAuthorization();
app.MapControllers();

app.Run();

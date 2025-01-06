using AutoMapper;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Services.Contracts;
using Shared.DTO.Auth;
using Domain.Contracts;
using Domain.Entities.Exceptions;
namespace Services;

internal sealed class AuthenticationService : IAuthenticationService
{

    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<MyUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly IRepositoryManager _repository;
    public AuthenticationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<MyUser> userManager, ITokenService tokenService)
    {
        _repository = repository;
        _tokenService = tokenService;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IdentityResult> Register(RegistrationRequestDto registerRequestBody)
    {
        var user = _mapper.Map<MyUser>(registerRequestBody);
        user.UserName = registerRequestBody.Email;

        var result = await _userManager.CreateAsync(user, registerRequestBody.Password!);

        if (!result.Succeeded)
        {
            throw new IdentityException(
                "Failed to register user"
                , result.Errors);  // Throw this exception to be caught globally
        }

        await _userManager.AddToRolesAsync(user, new[] { "User" });

        return result;
    }

    public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestBody)
    {
        var user = await _userManager.FindByEmailAsync(loginRequestBody.Email);

        var passwordValid = await _userManager.CheckPasswordAsync(user!, loginRequestBody.Password!);

        if (user == null || !passwordValid)
        {
            throw new UnauthorizedAccessException("Invalid Credentials");
        }
        // Get the user's roles
        var roles = await _userManager.GetRolesAsync(user);

        string AccessToken = await _tokenService.GenerateAccessToken(user);
        string RefreshToken = await _tokenService.GenerateAndSaveRefreshToken(user);

        UserResponseDto userRes = _mapper.Map<UserResponseDto>((user, roles));
        LoginResponseDto response = _mapper.Map<LoginResponseDto>((userRes, AccessToken, RefreshToken));
        return response;
    }



    public async Task<UserResponseDto> GetCurrentUser(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId) ?? throw new UserNotFoundException(userId);
        var roles = await _userManager.GetRolesAsync(user!);
        return _mapper.Map<UserResponseDto>((user, roles));
    }
}
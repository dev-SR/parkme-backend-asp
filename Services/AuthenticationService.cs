using System;
using AutoMapper;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Services.Contracts;
using Shared.DTO;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using Domain.Entities.ConfigurationModels;
using Domain.Entities.Exceptions;
using Shared.DTO.Auth;
using Domain.Contracts;
namespace Services;

internal sealed class AuthenticationService : IAuthenticationService
{

    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;
    private readonly IRepositoryManager _repository;
    public AuthenticationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, ITokenService tokenService)
    {
        _repository = repository;
        _tokenService = tokenService;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }


    public async Task<IdentityResult> Register(RegistrationRequestDto registerRequestBody)
    {
        var user = _mapper.Map<User>(registerRequestBody);
        user.UserName = registerRequestBody.Email; //UserName is required in Identity;email is used as username;

        var result = await _userManager.CreateAsync(user, registerRequestBody.Password!);

        if (result.Succeeded)
            await _userManager.AddToRolesAsync(user, ["User"]);
        return result;
    }

    public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestBody)
    {
        var user = await _userManager.FindByEmailAsync(loginRequestBody.Email);
        _logger.LogInfo($" User with email: {loginRequestBody.Email} attempted to log in.");

        var passwordValid = await _userManager.CheckPasswordAsync(user!, loginRequestBody.Password!);

        _logger.LogInfo($" User with email: {passwordValid}");
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

}
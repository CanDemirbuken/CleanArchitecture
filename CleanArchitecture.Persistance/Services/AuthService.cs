using AutoMapper;
using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Application.Feature.AuthFeatures.Commands.Login;
using CleanArchitecture.Application.Feature.AuthFeatures.Commands.Register;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Services;

public class AuthService(UserManager<AppUser> userManager, IMapper mapper, IJwtProvider jwtProvider) : IAuthService
{
    public async Task<LoginCommandResponse> LoginAsync(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? user = await userManager.Users.Where(p => p.UserName == request.UserNameOrEmail || p.Email == request.UserNameOrEmail).FirstOrDefaultAsync();
        if (user is null)
            throw new Exception("Kullanıcı bulunamadı!");

        var result = await userManager.CheckPasswordAsync(user, request.Password);
        if (result)
        {
            LoginCommandResponse response = await jwtProvider.CreateTokenAsync(user);
            return response;
        }

        throw new Exception("Kullanıcı adı veya şifre hatalı!");
    }

    public async Task RegisterAsync(RegisterCommand request)
    {
        AppUser user = mapper.Map<AppUser>(request);
        IdentityResult result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
            throw new Exception(result.Errors.First().Description);
    }
}
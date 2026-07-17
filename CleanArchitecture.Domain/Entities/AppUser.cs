using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities;

public sealed class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExpires { get; set; }
}
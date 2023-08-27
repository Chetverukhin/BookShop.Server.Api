using System.Security.Claims;

namespace BookShop.Server.Infrastructure
{
    public static class IdentityExtentions
    {
        public static string? GetId(this ClaimsPrincipal user) 
            => user
                .Claims
                .FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)
                ?.Value;
    }
}

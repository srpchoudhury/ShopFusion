using Microsoft.AspNetCore.Identity;

namespace ShopFusion.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

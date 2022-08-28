using Microsoft.AspNetCore.Identity;

namespace RemittanceAdvice.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}

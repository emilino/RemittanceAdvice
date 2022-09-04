using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RemittanceAdvice.Models.Data
{
    public class ApplicationContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {}
    }
}

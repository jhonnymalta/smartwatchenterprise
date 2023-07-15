using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SWE.Identidade.Api.Data
{
    public class AplicationDbContext: IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
    }
}

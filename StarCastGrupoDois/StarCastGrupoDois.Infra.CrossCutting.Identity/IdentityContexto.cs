using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarCastGrupoDois.Infra.CrossCutting.Identity.Models;

namespace StarCastGrupoDois.Infra.CrossCutting.Identity
{
    public class IdentityContexto : IdentityDbContext<Usuario>
    {
        public IdentityContexto(DbContextOptions<IdentityContexto> options) : base(options)
        {
        }
    }
}
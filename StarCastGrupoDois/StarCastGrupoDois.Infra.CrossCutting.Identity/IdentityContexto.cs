using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarCastGrupoDois.Infra.CrossCutting.Identity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.CrossCutting.Identity
{
    public class IdentityContexto : IdentityDbContext<ApplicationUser>
    {
        public IdentityContexto(DbContextOptions<IdentityContexto> options) : base(options) { }

    }
}

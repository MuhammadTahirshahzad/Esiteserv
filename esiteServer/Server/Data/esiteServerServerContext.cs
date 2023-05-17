using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using esiteServer.Shared;

namespace esiteServer.Server.Data
{
    public class esiteServerServerContext : DbContext
    {
        public esiteServerServerContext (DbContextOptions<esiteServerServerContext> options)
            : base(options)
        {
        }

        public DbSet<esiteServer.Shared.Login> Login { get; set; } = default!;
    }
}

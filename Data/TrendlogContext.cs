using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrendlogVisualization.Data
{
    public class TrendlogContext : DbContext
    {
        public TrendlogContext(DbContextOptions<TrendlogContext> options)
            : base(options)
        {
        }

        public DbSet<Models.SuperDataClass> SuperData { get; set; }
        public DbSet<Models.Author> Authors { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeedSearcher.Models;

namespace SeedSearcher.Data
{
    public class SeedSearcherContext : DbContext
    {
        public SeedSearcherContext (DbContextOptions<SeedSearcherContext> options)
            : base(options)
        {
        }

        public DbSet<SeedSearcher.Models.Bird> Bird { get; set; }
    }
}

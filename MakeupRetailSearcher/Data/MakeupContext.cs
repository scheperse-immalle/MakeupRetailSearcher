using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MakeupRetailSearcher.Models
{
    public class MakeupContext : DbContext
    {
        public MakeupContext (DbContextOptions<MakeupContext> options)
            : base(options)
        {
        }

        public DbSet<MakeupRetailSearcher.Models.Makeup> Makeup { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MakeupRetailSearcher.Models;

namespace MakeupRetailSearcher.Models
{
    public class MakeupContext : DbContext
    {
        public MakeupContext (DbContextOptions<MakeupContext> options)
            : base(options)
        {
        }

        public DbSet<MakeupRetailSearcher.Models.Makeup> Makeup { get; set; }

        public DbSet<MakeupRetailSearcher.Models.Retailer> Retailer { get; set; }
    }
}

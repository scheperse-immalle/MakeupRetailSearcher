using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MakeupRetailSearcher.Models
{
    public class RetailerContext : DbContext
    {
        public RetailerContext (DbContextOptions<RetailerContext> options)
            : base(options)
        {
        }

        public DbSet<MakeupRetailSearcher.Models.Retailer> Retailer { get; set; }
    }
}

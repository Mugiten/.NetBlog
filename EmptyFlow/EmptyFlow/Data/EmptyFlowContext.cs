using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmptyFlow.Models
{
    public class EmptyFlowContext : DbContext
    {
        public EmptyFlowContext (DbContextOptions<EmptyFlowContext> options)
            : base(options)
        {
        }

        public DbSet<EmptyFlow.Models.BlogPost> BlogPost { get; set; }
    }
}

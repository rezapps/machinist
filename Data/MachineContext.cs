using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using machinist.Models;

namespace machinist.Data
{
    public class MachineContext : DbContext
    {
        public MachineContext (DbContextOptions<MachineContext> options)
            : base(options)
        {
        }

        public DbSet<machinist.Models.Company> Company { get; set; } = default!;
        public DbSet<machinist.Models.Commando> Commando { get; set; } = default!;
        public DbSet<machinist.Models.Machine> Machine { get; set; } = default!;
    }
}

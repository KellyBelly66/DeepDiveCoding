using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CellPhones.Models
{
    public class CellPhonesContext : DbContext
    {
        public CellPhonesContext (DbContextOptions<CellPhonesContext> options)
            : base(options)
        {
        }

        public DbSet<CellPhones.Models.Cellphone> Cellphone { get; set; }
    }
}

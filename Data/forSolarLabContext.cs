using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using forSolarLab.Models;

namespace forSolarLab.Data
{
    public class forSolarLabContext : DbContext
    {
        public forSolarLabContext (DbContextOptions<forSolarLabContext> options)
            : base(options)
        {
        }

        public DbSet<forSolarLab.Models.Person> Person { get; set; }
    }
}

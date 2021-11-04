using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demoMvc.Models;

namespace demoMvc.Data
{
    public class demoMvcContext : DbContext
    {
        public demoMvcContext (DbContextOptions<demoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<demoMvc.Models.Movie> Movie { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Models;

namespace PizzariaAPI.Data
{
    public class PizzariaAPIContext : DbContext
    {
        public PizzariaAPIContext (DbContextOptions<PizzariaAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PizzariaAPI.Models.Pizza>? Pizza { get; set; }
    }
}

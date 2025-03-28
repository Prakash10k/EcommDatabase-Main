using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecomm_Database_Class.Model; // Add this line

namespace Ecomm_Database_Class.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ECommerce;Integrated Security=True;TrustServerCertificate=true");
        }

        public DbSet<Order> Orders { get; set; }
    }
}

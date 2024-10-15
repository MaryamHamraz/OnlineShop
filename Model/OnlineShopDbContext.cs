using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model
{

    public class OnlineShopDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True;");
            //Data Source =.; Initial Catalog = FinalProjectDb; Integrated Security = True
        }
    }

}

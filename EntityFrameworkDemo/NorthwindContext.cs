using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        //veritabanıyla classları ilişkilendiren class
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//dbdeki metot gittiğinde görürsün bunu ezmek zorundayız ki istediğimiz zaman değiştirelim.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
   

}

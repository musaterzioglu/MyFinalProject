using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje class'larını ilişkilendirerek bağlar.
    public class NorthwindContext:DbContext
    {
        //Bu methot senin projenin hangi veritabani ile ilişkisi olduğunu belirteceğimiz yerdir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@=normal ters slash
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } //Benim Product nesnemi veritabanımdaki Products ile bağla.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

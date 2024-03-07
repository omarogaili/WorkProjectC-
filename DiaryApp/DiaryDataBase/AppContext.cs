using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DiaryDataBase
{
    public class AppContext : DbContext
    {
        //creating the tabels for the Diary database using SQL Server DbSet
        public DbSet<Customer> Customers {  get; set; } // crate an object for the users collection
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Comment> Comments { get; set; }
        // sending the Connictionstring 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DiaryApp"); //can be changed if u have another server. 
        }

    }
}

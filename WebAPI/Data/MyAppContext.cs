

using Microsoft.EntityFrameworkCore;

using WebAPI.Models;
namespace WebAPI.Data;

  public class MyAppContext : DbContext
    {
        // public DbSet<Address> Address { get; set; }
        // public DbSet<Customer> Customers { get; set; }

        // Create a Table:
        // public DbSet<Model> TableName { get; set; }
          public MyAppContext(DbContextOptions<MyAppContext> options)
      : base(options)
  {
  }
        public DbSet<ActivityModel>? ActivityList { get; set; }
        
        
    }
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Http;
using TestEfCore.Models;

namespace TestEfCore.Data
{
    public class DataContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<EventHistory> EventHistories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa123456789@;Persist Security Info=True;User ID=sa;Initial Catalog=TesteEventoApp;Data Source=ATLANTICO03958");//aqui vou passar a string de conexão
            
        }
        /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new List<User>()
            {
                new User (1, "roberto"),
                new User (2, "Lauro"),

            });

            builder.Entity<Subscription>().HasData(new List<Subscription>()
            {
                new Subscription (1, 2),
                new Subscription (2, 1)

            });
           
        }
        */
        }
}

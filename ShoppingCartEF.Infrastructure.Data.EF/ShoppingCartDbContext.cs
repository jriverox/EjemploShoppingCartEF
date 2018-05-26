using Microsoft.EntityFrameworkCore;
using ShoppingCartEF.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Infrastructure.Data.EF
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(i => i.Items)
                .HasForeignKey(i => i.OrderId);


        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

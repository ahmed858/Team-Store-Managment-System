using APP.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Context
{
    internal class TeamStoreContext:DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInStock> ProductsInStock { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TeamStore;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Configure the Product entity
            modelBuilder.Entity<Product>(entity =>
            {
                // Primary key
                entity.HasKey(p => p.ProductId);
                entity.Property(e => e.ProductId)
                   .ValueGeneratedNever();

                // Define the foreign key relationship
                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .IsRequired(); // Mark the foreign key as required

                // Set column data types, precision, and scale for decimal properties
                entity.Property(p => p.SellPrice)
                    .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

                entity.Property(p => p.PurchasePrice)
                    .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            });

            // Configure the ProductInStock entity
            modelBuilder.Entity<ProductInStock>(entity =>
            {
                // Primary key
                entity.HasKey(p => p.Id);

                // Define the foreign key relationships
                entity.HasOne(p => p.Category)
                    .WithMany(c => c.ProductsInStock)
                    .HasForeignKey(p => p.CategoryId)
                    .IsRequired();

                entity.HasOne(p => p.Stock)
                    .WithMany(s => s.ProductsInStock)
                    .HasForeignKey(p => p.StockId)
                    .IsRequired();

                // Set column data types, precision, and scale for decimal properties
                entity.Property(p => p.PurchasePrice)
                    .HasColumnType("decimal(18, 2)");

                entity.Property(p => p.SellPrice)
                    .HasColumnType("decimal(18, 2)");

                entity.Property(p => p.Quantity)
                    .HasColumnType("decimal(18, 2)");

                // Other property configurations, if needed
            });
            // Configure the User entity

            modelBuilder.Entity<User>(entity =>
            {
                // Unique constraint on the 'Code' property
                entity.HasIndex(e => e.UserName)
                      .IsUnique();

                // Other property configurations...
            });
        }

    }
}

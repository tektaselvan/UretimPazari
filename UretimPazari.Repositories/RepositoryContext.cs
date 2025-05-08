using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories
{
    public class RepositoryContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HomePageContent> HomePages { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Offer ve Supplier arasındaki ilişkiyi NoAction olarak ayarlıyoruz
            modelBuilder.Entity<Offer>()
                .HasOne(o => o.Supplier)
                .WithMany(s => s.Offers)
                .HasForeignKey(o => o.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);  // Silme işlemi etkilenmez

            // Diğer Foreign Key ilişkilerinde de benzer işlemi yapabilirsiniz
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);  // Silme işlemi etkilenmez


           

            // Listing - Producer ilişkisi
            modelBuilder.Entity<Listing>()
                .HasOne(l => l.Producer)
                .WithMany(p => p.Listings)  // Eğer Producer sınıfında Listings koleksiyonu varsa
                .HasForeignKey(l => l.ProducerId)
                .OnDelete(DeleteBehavior.NoAction);  // Silme işlemi zincirleme olmasın

            // Listing - Product ilişkisi
            modelBuilder.Entity<Listing>()
                .HasOne(l => l.Product)
                .WithMany(p => p.Listings)  // Eğer Product sınıfında Listings koleksiyonu varsa
                .HasForeignKey(l => l.ProductId)
                .OnDelete(DeleteBehavior.NoAction);  // Silme işlemi zincirleme olmasın

            // Offer - Listing ilişkisi
            modelBuilder.Entity<Offer>()
                .HasOne(o => o.Listing)
                .WithMany(l => l.Offers)
                .HasForeignKey(o => o.ListingId)
                .OnDelete(DeleteBehavior.NoAction);

            // Producer - User ilişkisi
            modelBuilder.Entity<Producer>()
                .HasOne(p => p.User)
                .WithMany() // Eğer User tarafında Producers gibi koleksiyon yoksa
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Supplier - User ilişkisi (Eğer varsa)
            modelBuilder.Entity<Supplier>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

    }
}

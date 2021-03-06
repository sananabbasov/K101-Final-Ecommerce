using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess
{
    public class EcommerceContext:IdentityDbContext<K101User>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Picture> Pictures{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advertisement> Advertisementies { get; set; }
        public DbSet<K101User> K101Users { get; set; }
        public DbSet<HitCounter> HitCounters { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!

            modelBuilder.Entity<K101User>().ToTable("Users");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}

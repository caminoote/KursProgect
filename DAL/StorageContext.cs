using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class StorageContext : DbContext
    {
        public StorageContext()
            : base("name=StorageContext")
        {
        }

        public virtual DbSet<addString> addString { get; set; }
        public virtual DbSet<Out> Out { get; set; }
        public virtual DbSet<OutString> OutString { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Shops> Shops { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<Trader> Trader { get; set; }
        public virtual DbSet<typegoods> typegoods { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<addString>()
                .HasMany(e => e.OutString)
                .WithRequired(e => e.addString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.NameProduct)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.addString)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shops>()
                .Property(e => e.Locate)
                .IsUnicode(false);

            modelBuilder.Entity<Shops>()
                .HasMany(e => e.Out)
                .WithRequired(e => e.Shops)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supply>()
                .HasMany(e => e.addString)
                .WithRequired(e => e.Supply)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.NameTrader)
                .IsFixedLength();

            modelBuilder.Entity<Trader>()
                .Property(e => e.Locate)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .HasMany(e => e.Supply)
                .WithRequired(e => e.Trader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<typegoods>()
                .Property(e => e.TypeGoods1)
                .IsFixedLength();

            modelBuilder.Entity<typegoods>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.typegoods)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SecondName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Supply)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}

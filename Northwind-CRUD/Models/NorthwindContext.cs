namespace Northwind_CRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=Northwind")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<供應商> 供應商s { get; set; }
        public virtual DbSet<客戶> 客戶s { get; set; }
        public virtual DbSet<訂貨主檔> 訂貨主檔s { get; set; }
        public virtual DbSet<訂貨明細> 訂貨明細s { get; set; }
        public virtual DbSet<員工> 員工s { get; set; }
        public virtual DbSet<產品資料> 產品資料s { get; set; }
        public virtual DbSet<產品類別> 產品類別s { get; set; }
        public virtual DbSet<貨運公司> 貨運公司s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<訂貨主檔>()
                .Property(e => e.運費)
                .HasPrecision(19, 4);

            modelBuilder.Entity<訂貨主檔>()
                .HasMany(e => e.訂貨明細)
                .WithRequired(e => e.訂貨主檔)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<訂貨明細>()
                .Property(e => e.單價)
                .HasPrecision(19, 4);

            modelBuilder.Entity<產品資料>()
                .Property(e => e.單價)
                .HasPrecision(19, 4);

            modelBuilder.Entity<產品資料>()
                .HasMany(e => e.訂貨明細)
                .WithRequired(e => e.產品資料)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<貨運公司>()
                .HasMany(e => e.訂貨主檔)
                .WithOptional(e => e.貨運公司)
                .HasForeignKey(e => e.送貨方式);
        }
    }
}

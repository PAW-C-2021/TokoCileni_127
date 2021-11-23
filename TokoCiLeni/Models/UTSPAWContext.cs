using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class UTSPAWContext : DbContext
    {
        public UTSPAWContext()
        {
        }

        public UTSPAWContext(DbContextOptions<UTSPAWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("Id_Admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminName)
                    .HasColumnName("Admin_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("Id_Customer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("Id_Customer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alamat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdItem).HasColumnName("Id_Item");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.IdItem)
                    .HasConstraintName("FK_Customer_Item");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.Property(e => e.IdItem)
                    .HasColumnName("Id_Item")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPayment).HasColumnName("Id_Payment");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber)
                    .HasColumnName("Item_Number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaymentNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.IdPayment)
                    .HasConstraintName("FK_Item_PAyment");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment);

                entity.ToTable("PAyment");

                entity.Property(e => e.IdPayment)
                    .HasColumnName("Id_Payment")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdCustomer).HasColumnName("Id_Customer");

                entity.Property(e => e.IdSeller).HasColumnName("Id_Seller");

                entity.Property(e => e.TotalPayment)
                    .HasColumnName("Total_Payment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("FK_PAyment_Customer");

                entity.HasOne(d => d.IdSellerNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.IdSeller)
                    .HasConstraintName("FK_PAyment_Seller");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.IdSeller);

                entity.Property(e => e.IdSeller)
                    .HasColumnName("Id_Seller")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdAdmin).HasColumnName("Id_Admin");

                entity.Property(e => e.SellerName)
                    .HasColumnName("Seller_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAdminNavigation)
                    .WithMany(p => p.Seller)
                    .HasForeignKey(d => d.IdAdmin)
                    .HasConstraintName("FK_Seller_Admin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

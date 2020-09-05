namespace CommanderWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CommanderEDM : DbContext
    {
        public CommanderEDM()
            : base("name=CommanderEDM")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminType)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.ThemeColor)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Cellphone)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cellphone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ThemeColor)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Delivery>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Delivery>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Delivery)
                .HasForeignKey(e => e.Delivery_ID);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.Orders1)
                .WithOptional(e => e.Delivery1)
                .HasForeignKey(e => e.Delivery_ID);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Discount)
                .HasForeignKey(e => e.Discount_ID);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Payments1)
                .WithOptional(e => e.Discount1)
                .HasForeignKey(e => e.Discount_ID);

            modelBuilder.Entity<Order>()
                .Property(e => e.Final_Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Payment>()
                .Property(e => e.AmountDue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Wishlists)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_ID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Wishlists1)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.Product_ID);

            modelBuilder.Entity<Brand>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.Descrption)
                .IsUnicode(false);
        }
    }
}

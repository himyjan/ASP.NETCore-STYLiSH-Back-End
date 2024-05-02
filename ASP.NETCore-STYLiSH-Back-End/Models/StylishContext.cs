using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore_STYLiSH_Back_End.Models;

public partial class StylishContext : DbContext
{
    public StylishContext()
    {
    }

    public StylishContext(DbContextOptions<StylishContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Hot> Hots { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Otherimage> Otherimages { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;User ID=sa;Password=Password123;Initial Catalog=stylish;TrustServerCertificate=true;Persist Security Info=False;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_campaign_product_id");

            entity.ToTable("campaign");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.Picture)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("picture");
            entity.Property(e => e.Story)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("story");
        });

        modelBuilder.Entity<Hot>(entity =>
        {
            entity.HasKey(e => e.Title).HasName("PK_hots_title");

            entity.ToTable("hots");

            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Products)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("products");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_orders_order_id");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.LastFour)
                .HasMaxLength(45)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("last_four");
            entity.Property(e => e.OrderProducts)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("order_products");
            entity.Property(e => e.Pay)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("pay");
            entity.Property(e => e.PayOrders)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("pay_orders");
            entity.Property(e => e.Payment)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("payment");
            entity.Property(e => e.Shipping)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("shipping");
            entity.Property(e => e.Time)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("time");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("total");
            entity.Property(e => e.User)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_id");
            entity.Property(e => e.UserOrders)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_orders");
        });

        modelBuilder.Entity<Otherimage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("otherimages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("id");
            entity.Property(e => e.ImagesUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("images_url");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("otherimages$otherimages_ibfk_1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_product_id");

            entity.ToTable("product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("description");
            entity.Property(e => e.MainImage)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("main_image");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("note");
            entity.Property(e => e.Place)
                .HasMaxLength(45)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("place");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("price");
            entity.Property(e => e.Story)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("story");
            entity.Property(e => e.Texture)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("texture");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Wash)
                .HasMaxLength(45)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("wash");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_user_id");

            entity.ToTable("user");

            entity.HasIndex(e => e.Email, "user$email_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("password");
            entity.Property(e => e.Picture)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("picture");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("provider");
        });

        modelBuilder.Entity<Variant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("variant");

            entity.Property(e => e.ColorCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("color_code");
            entity.Property(e => e.ColorName)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("color_name");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("id");
            entity.Property(e => e.Size)
                .HasMaxLength(45)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("size");
            entity.Property(e => e.Stock)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("stock");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

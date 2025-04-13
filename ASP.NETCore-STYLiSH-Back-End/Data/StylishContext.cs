using System;
using System.Collections.Generic;
using ASP.NETCore_STYLiSH_Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore_STYLiSH_Back_End.Data;

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
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=STYLiSH;Encrypt=False;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
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
        modelBuilder.Entity<Campaign>().HasData(
            new Campaign
            {
                ProductId = 201807242228,
                Picture = "http://localhost:5130/images/201807242228.jpg",
                Story = "於是\n我也想要給你\n一個那麼美好的自己。\n不朽《與自己和好如初》"
            },
            new Campaign
            {
                ProductId = 201807202140,
                Picture = "http://localhost:5130/images/201807202140.jpg",
                Story = "瞬間\n在城市的角落\n找到失落多時的記憶。\n印象《都會故事集》"
            },
            new Campaign
            {
                ProductId = 201807242222,
                Picture = "http://localhost:5130/images/201807242222.jpg",
                Story = "永遠\n展現自信與專業\n無法抵擋的男人魅力。\n復古《再一次經典》"
            }
        );

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
        modelBuilder.Entity<Hot>().HasData(
            new Hot
            {
                Title = "熱門商品",
                Products = "201807201824,201807202140,201807242222"
            }
        );


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
        modelBuilder.Entity<Order>().HasData(
        );

        modelBuilder.Entity<Otherimage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_otherimage");

            entity.ToTable("otherimages");

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
        // modelBuilder.Entity<Otherimage>().HasData(
        //     new Otherimage
        //     {
        //         Id = 1,
        //         ImagesUrl = "http://localhost:5130/products/201807201824/other_images-0.jpg"
        //     },
        //     new Otherimage
        //     {
        //         Id = 2,
        //         ImagesUrl = "http://localhost:5130/products/201807201824/other_images-1.jpg"
        //     },
        //     new Otherimage
        //     {
        //         Id = 3,
        //         ImagesUrl = "http://localhost:5130/products/201807202140/other_images-0.jpg"
        //     },
        //     new Otherimage
        //     {
        //         Id = 4,
        //         ImagesUrl = "http://localhost:5130/products/201807202140/other_images-1.jpg"
        //     }
        // );

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
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 201807201824,
                Title = "前開衩扭結洋裝",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 799,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807201824.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201807202140,
                Title = "透肌澎澎防曬襯衫",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 599,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807202140.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201807202150,
                Title = "小扇紋細織上衣",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 599,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807202150.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201807202157,
                Title = "活力花紋長筒牛仔褲",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 1299,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807202157.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201807242211,
                Title = "純色輕薄百搭襯衫",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 799,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242211.jpg",
                Category = "men"
            },
            new Product
            {
                Id = 201807242216,
                Title = "時尚輕鬆休閒西裝",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 2399,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242216.jpg",
                Category = "men"
            },
            new Product
            {
                Id = 201807242222,
                Title = "經典商務西裝",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 3999,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242222.jpg",
                Category = "men"
            },
            new Product
            {
                Id = 201807242228,
                Title = "夏日海灘戶外遮陽帽",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 1499,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242228.jpg",
                Category = "accessories"
            },
            new Product
            {
                Id = 201807242230,
                Title = "經典牛仔帽",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 799,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242230.jpg",
                Category = "accessories"
            },
            new Product
            {
                Id = 201807242232,
                Title = "卡哇伊多功能隨身包",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 1299,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242232.jpg",
                Category = "accessories"
            },
            new Product
            {
                Id = 201807242234,
                Title = "柔軟氣質羊毛圍巾",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 1799,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201807242234.jpg",
                Category = "accessories"
            },
            new Product
            {
                Id = 201902191210,
                Title = "精緻扭結洋裝",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 999,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201902191210.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201902191242,
                Title = "透肌澎澎薄紗襯衫",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 999,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201902191242.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201902191245,
                Title = "小扇紋質感上衣",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 999,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201902191245.jpg",
                Category = "women"
            },
            new Product
            {
                Id = 201902191247,
                Title = "經典修身長筒牛仔褲",
                Description = "厚薄：薄\r\n彈性：無",
                Price = 1999,
                Texture = "棉 100%",
                Wash = "手洗，溫水",
                Place = "中國",
                Note = "實品顏色依單品照為主",
                Story = "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.",
                MainImage = "http://localhost:5130/images/products/201902191247.jpg",
                Category = "women"
            }
        );        

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
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 38,
                Provider = "facebook",
                Name = "test",
                Email = "test@gmail.com",
                Picture = "http",
                Password = "90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4"
            },
            new User
            {
                Id = 39,
                Provider = "native",
                Name = "test",
                Email = "test2@gmail.com",
                Picture = "http",
                Password = "90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4"
            }
        );

        modelBuilder.Entity<Variant>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ColorCode, e.Size }).HasName("PK_variant");
            
            entity.ToTable("variant");

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
        modelBuilder.Entity<Variant>().HasData(
            new Variant
            {
                Id = 201807201824,
                ColorCode = "FFFFFF",
                ColorName = "白色",
                Size = "S",
                Stock = 2
            },
            new Variant
            {
                Id = 201807201824,
                ColorCode = "FFFFFF",
                ColorName = "白色",
                Size = "M",
                Stock = 2
            },
            new Variant
            {
                Id = 201807201824,
                ColorCode = "FFFFFF",
                ColorName = "白色",
                Size = "L",
                Stock = 2
            },
            new Variant
            {
                Id = 201807202140,
                ColorCode = "DDFFBB",
                ColorName = "亮綠",
                Size = "S",
                Stock = 12
            },
            new Variant
            {
                Id = 201807202140,
                ColorCode = "DDFFBB",
                ColorName = "亮綠",
                Size = "M",
                Stock = 10
            },
            new Variant
            {
                Id = 201807202140,
                ColorCode = "DDFFBB",
                ColorName = "亮綠",
                Size = "L",
                Stock = 10
            }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

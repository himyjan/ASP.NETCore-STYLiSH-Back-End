using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NETCore_STYLiSH_Back_End.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "campaign",
                columns: table => new
                {
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    story = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campaign_product_id", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "hots",
                columns: table => new
                {
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    products = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hots_title", x => x.title);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    time = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    total = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    user_orders = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    pay_orders = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    payment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    shipping = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    pay = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "(NULL)"),
                    order_products = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    user = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    last_four = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_order_id", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    price = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    texture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    wash = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true, defaultValueSql: "(NULL)"),
                    place = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true, defaultValueSql: "(NULL)"),
                    note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    story = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    main_image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    picture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "variant",
                columns: table => new
                {
                    color_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(NULL)"),
                    size = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false, defaultValueSql: "(NULL)"),
                    id = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(NULL)"),
                    stock = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    color_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_variant", x => new { x.id, x.color_code, x.size });
                });

            migrationBuilder.CreateTable(
                name: "otherimages",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(NULL)"),
                    images_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otherimage", x => x.id);
                    table.ForeignKey(
                        name: "otherimages$otherimages_ibfk_1",
                        column: x => x.id,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "campaign",
                columns: new[] { "product_id", "picture", "story" },
                values: new object[,]
                {
                    { 201807202140L, "/img/campain_201807202140.jpg", "瞬間\n在城市的角落\n找到失落多時的記憶。\n印象《都會故事集》" },
                    { 201807242222L, "/img/campain_201807242222.jpg", "永遠\n展現自信與專業\n無法抵擋的男人魅力。\n復古《再一次經典》" }
                });

            migrationBuilder.InsertData(
                table: "hots",
                columns: new[] { "title", "products" },
                values: new object[] { "熱門商品", "201807201824,201807202140,201807242222" });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category", "description", "main_image", "note", "place", "price", "story", "texture", "title", "wash" },
                values: new object[,]
                {
                    { 201807201824L, "women", "厚薄：薄\r\n彈性：無", "https://d38p3ocem7m9yt.cloudfront.net/products/201807201824/main_image.jpg", "實品顏色依單品照為主", "中國", 799, "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.", "棉 100%", "前開衩扭結洋裝", "手洗，溫水" },
                    { 201807202140L, "women", "厚薄：薄\r\n彈性：無", "https://d38p3ocem7m9yt.cloudfront.net/products/201807202140/main_image.jpg", "實品顏色依單品照為主", "中國", 599, "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.", "棉 100%", "透肌澎澎防曬襯衫", "手洗，溫水" },
                    { 201807242222L, "men", "厚薄：薄\r\n彈性：無", "https://d38p3ocem7m9yt.cloudfront.net/products/201807242222/main_image.jpg", "實品顏色依單品照為主", "中國", 3999, "O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.", "棉 100%", "經典商務西裝", "手洗，溫水" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "email", "name", "password", "picture", "provider" },
                values: new object[,]
                {
                    { 38, "test@gmail.com", "test", "90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4", "http", "facebook" },
                    { 39, "test2@gmail.com", "test", "90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4", "http", "native" }
                });

            migrationBuilder.InsertData(
                table: "variant",
                columns: new[] { "color_code", "id", "size", "color_name", "stock" },
                values: new object[,]
                {
                    { "FFFFFF", 201807201824L, "L", "白色", 2 },
                    { "FFFFFF", 201807201824L, "M", "白色", 2 },
                    { "FFFFFF", 201807201824L, "S", "白色", 2 },
                    { "DDFFBB", 201807202140L, "L", "亮綠", 10 },
                    { "DDFFBB", 201807202140L, "M", "亮綠", 10 },
                    { "DDFFBB", 201807202140L, "S", "亮綠", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "user$email_UNIQUE",
                table: "user",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "campaign");

            migrationBuilder.DropTable(
                name: "hots");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "otherimages");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "variant");

            migrationBuilder.DropTable(
                name: "product");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NETCore_STYLiSH_Back_End.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    color_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    size = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true, defaultValueSql: "(NULL)"),
                    stock = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    id = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "(NULL)"),
                    color_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "otherimages",
                columns: table => new
                {
                    images_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    id = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "otherimages$otherimages_ibfk_1",
                        column: x => x.id,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_otherimages_id",
                table: "otherimages",
                column: "id");

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

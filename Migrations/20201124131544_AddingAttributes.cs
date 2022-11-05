using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COSE71197_DL.Migrations
{
    public partial class AddingAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    TownOrCity = table.Column<string>(nullable: false),
                    County = table.Column<string>(maxLength: 100, nullable: false),
                    PostCode = table.Column<string>(maxLength: 7, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    HardwareId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Hardwares_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardwares",
                        principalColumn: "HardwareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\209px-Toshiba_HD-A1_motherboard_20081026.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum_thumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\320px-D-Link_DES-1024R91906.jpg", "\\Images\\D-Link_DES-1024R91906.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\320px-Vertex_2_Solid_State_Drive.jpg", "\\Images\\Vertex_2_Solid_State_Drive.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\180px-Marshall_JCM800_amplifier.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-Headphones_1.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-R.A.Moog_minimoog_2.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\320px-Vox_Tone_Bender.jpg", "\\Images\\800px-Vox_Tone_Bender.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\EthernetCableGreenThumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\HDMI_to_Micro_thumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-Power_cord_(817840840).jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 14,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\218px-Cable-ecran-VGA.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 15,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\320px-Serial_Cable_thumbnail.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_HardwareId",
                table: "OrderDetails",
                column: "HardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\209px-Toshiba_HD-A1_motherboard_20081026.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum_thumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\320px-D-Link_DES-1024R+-91906.jpg", "\\Images\\D-Link_DES-1024R+-91906.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg", "\\Images\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\180px-Marshall_JCM800_amplifier.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-Headphones_1.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-R.A.Moog_minimoog_2.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\320px-Vox_Tone_Bender.jpg", "\\Images\\Turntables_and_mixer.jpg" });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\EthernetCableGreenThumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\HDMI_to_Micro_thumbnail.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-Power_cord_(817840840).jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 14,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\218px-Cable-ecran-VGA.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 15,
                column: "ImageThumbnailUrl",
                value: "~\\Images\\thumbnails\\320px-Serial_Cable_thumbnail.jpg");
        }
    }
}

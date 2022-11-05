using Microsoft.EntityFrameworkCore.Migrations;

namespace COSE71197_DL.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<int>(nullable: false),
                    HardwareId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Hardwares_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardwares",
                        principalColumn: "HardwareId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 1,
                column: "ImageUrl",
                value: "\\Images\\Toshiba_HD-A1_motherboard_20081026.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\Images\\800px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 3,
                column: "ImageUrl",
                value: "\\Images\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\Images\\D-Link_DES-1024R+-91906.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 5,
                column: "ImageUrl",
                value: "\\Images\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 6,
                column: "ImageUrl",
                value: "\\Images\\Marshall_JCM800_amplifier.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 7,
                column: "ImageUrl",
                value: "\\Images\\Headphones_1.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 8,
                column: "ImageUrl",
                value: "\\Images\\R.A.Moog_minimoog_2.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 9,
                column: "ImageUrl",
                value: "\\Images\\Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 10,
                column: "ImageUrl",
                value: "\\Images\\Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 11,
                column: "ImageUrl",
                value: "\\Images\\EthernetCableGreen.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 12,
                column: "ImageUrl",
                value: "\\Images\\HDMI_to_Micro.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 13,
                column: "ImageUrl",
                value: "\\Images\\800px-Power_cord_(817840840).jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 14,
                column: "ImageUrl",
                value: "\\Images\\Cable-ecran-VGA.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 15,
                column: "ImageUrl",
                value: "\\Images\\Serial_Cable.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_HardwareId",
                table: "ShoppingCartItems",
                column: "HardwareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~\\Images\\Toshiba_HD-A1_motherboard_20081026.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~\\Images\\800px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~\\Images\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~\\Images\\D-Link_DES-1024R+-91906.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 5,
                column: "ImageUrl",
                value: "~\\Images\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 6,
                column: "ImageUrl",
                value: "~\\Images\\Marshall_JCM800_amplifier.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 7,
                column: "ImageUrl",
                value: "~\\Images\\Headphones_1.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 8,
                column: "ImageUrl",
                value: "~\\Images\\R.A.Moog_minimoog_2.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 9,
                column: "ImageUrl",
                value: "~\\Images\\Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 10,
                column: "ImageUrl",
                value: "~\\Images\\Turntables_and_mixer.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 11,
                column: "ImageUrl",
                value: "~\\Images\\EthernetCableGreen.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 12,
                column: "ImageUrl",
                value: "~\\Images\\HDMI_to_Micro.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 13,
                column: "ImageUrl",
                value: "~\\Images\\800px-Power_cord_(817840840).jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 14,
                column: "ImageUrl",
                value: "~\\Images\\Cable-ecran-VGA.jpg");

            migrationBuilder.UpdateData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 15,
                column: "ImageUrl",
                value: "~\\Images\\Serial_Cable.jpg");
        }
    }
}

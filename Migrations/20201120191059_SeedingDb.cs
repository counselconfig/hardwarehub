using Microsoft.EntityFrameworkCore.Migrations;

namespace COSE71197_DL.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HardWareId",
                table: "Hardwares",
                newName: "HardwareId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Computing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "Audio" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Cables" });

            migrationBuilder.InsertData(
                table: "Hardwares",
                columns: new[] { "HardwareId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "\\Images\\thumbnails\\209px-Toshiba_HD-A1_motherboard_20081026.jpg", "\\Images\\Toshiba_HD-A1_motherboard_20081026.jpg", true, false, "Toshiba HD-A1 motherboard 20081026", 10.00m },
                    { 2, 1, "Pellentesque nec dolor sed ante dictum pretium. Ut aliquam augue sem, a rutrum elit fermentum vel. Sed interdum ligula tincidunt erat ornare hendrerit. Fusce sed semper est. In rhoncus luctus laoreet. Mauris venenatis pellentesque mi quis aliquam.", "\\Images\\thumbnails\\320px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg", "\\Images\\800px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg", true, true, "Intel CPU Core i7 6700K Skylake perspective", 50.00m },
                    { 3, 1, "Phasellus at ex vitae tortor laoreet viverra sed sed leo. Nulla congue ex id pretium consequat. Integer quis eleifend tellus. Proin id dapibus urna, et efficitur metus. Pellentesque accumsan gravida nulla ut cursus. Integer sit amet fringilla eros. Duis lacinia tincidunt ultrices.", "\\Images\\thumbnails\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum_thumbnail.jpg", "\\Images\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum.jpg", true, true, "Early Apple Macintosh with keyboard and mouse", 85.00m },
                    { 4, 1, "Praesent ornare velit tempus ornare bibendum. Donec gravida mi sed tincidunt pharetra. Sed ut purus vel nisi tincidunt fermentum sit amet sed orci. Sed consequat nisi id urna imperdiet ullamcorper. Phasellus bibendum lobortis risus, eget placerat justo sollicitudin et.", "\\Images\\thumbnails\\320px-D-Link_DES-1024R+-91906.jpg", "\\Images\\D-Link_DES-1024R+-91906.jpg", true, true, "D-Link DES-1024R+-91906", 100.00m },
                    { 5, 1, "Sed et turpis efficitur, dictum massa eget, rutrum sapien. Praesent faucibus elit ac dictum consectetur. Mauris sagittis at est vel finibus. Nam at nisi eros. Etiam massa erat, fermentum lobortis pellentesque et, blandit eget turpis. Ut fermentum leo non nisl ullamcorper scelerisque. Maecenas feugiat nunc eros, sed convallis ex dapibus id. Proin vitae dolor ut est dictum condimentum. Morbi ut rutrum lectus, quis suscipit libero. Vestibulum aliquam neque ut augue vestibulum lacinia.", "\\Images\\thumbnails\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg", "\\Images\\320px-Vertex_2_Solid_State_Drive_by_OCZ-top_oblique_PNr°0307.jpg", true, false, "Vertex 2 Solid State Drive by OCZ top oblique PNr°0307", 65.00m },
                    { 6, 2, "Quisque posuere vehicula libero eu porttitor. Sed et nunc nunc. Nulla elit tellus, interdum a neque ac, eleifend rutrum lorem. Mauris rhoncus, lorem nec posuere maximus, mi justo rhoncus neque, ut vestibulum felis ex non arcu. Aenean non mi sem. Pellentesque a congue quam.", "\\Images\\thumbnails\\180px-Marshall_JCM800_amplifier.jpg", "\\Images\\Marshall_JCM800_amplifier.jpg", true, false, "Marshall JCM800 amplifier", 195.00m },
                    { 7, 2, "At erat pellentesque adipiscing commodo elit at imperdiet. Diam vulputate ut pharetra sit. Cras tincidunt lobortis feugiat vivamus at. In nibh mauris cursus mattis molestie a iaculis at erat. Purus sit amet luctus venenatis lectus magna fringilla urna. Morbi tristique senectus et netus. Phasellus egestas tellus rutrum tellus pellentesque eu tincidunt tortor. Amet tellus cras adipiscing enim eu. Nunc sed blandit libero volutpat sed cras ornare arcu dui.", "\\Images\\thumbnails\\320px-Headphones_1.jpg", "\\Images\\Headphones_1.jpg", true, true, "Circumaural headphones", 25.00m },
                    { 8, 2, "Quisque non bibendum lectus. Proin tempor pulvinar lobortis. Proin auctor lorem vitae felis volutpat feugiat. Cras egestas diam a risus elementum, at semper turpis placerat. Sed molestie vulputate tellus. Mauris et massa elementum, lobortis velit nec, consequat risus. Nullam vel mi vitae nunc mattis ullamcorper.", "\\Images\\thumbnails\\320px-R.A.Moog_minimoog_2.jpg", "\\Images\\R.A.Moog_minimoog_2.jpg", true, true, "Minimoog sympthesiser", 135.00m },
                    { 9, 2, "Donec et dapibus erat, vitae tempus mauris. Duis cursus viverra metus, volutpat consequat quam rutrum nec. Nam massa ante, iaculis quis nunc sit amet, suscipit tristique massa. Aliquam posuere rutrum felis, vitae condimentum lectus lobortis eget. Aenean dignissim tempor ex, id tempus augue mattis et. Vestibulum ac fermentum risus, ac vulputate odio.", "\\Images\\thumbnails\\320px-Turntables_and_mixer.jpg", "\\Images\\Turntables_and_mixer.jpg", true, false, "Turntables and mixer", 170.00m },
                    { 10, 2, "Fusce lacinia augue eget felis rutrum, fringilla condimentum tellus mattis. Donec vitae sapien sit amet ligula molestie sagittis. In dignissim lacus in risus lobortis, quis varius est gravida. Integer in massa imperdiet, mattis turpis sed, laoreet risus. In a enim condimentum, facilisis diam vitae, eleifend mauris.", "\\Images\\thumbnails\\320px-Vox_Tone_Bender.jpg", "\\Images\\Turntables_and_mixer.jpg", true, true, "Vox Tone Bender", 65.00m },
                    { 11, 3, "Turpis egestas integer eget aliquet nibh. Viverra justo nec ultrices dui. Cum sociis natoque penatibus et magnis dis parturient montes nascetur. Tincidunt dui ut ornare lectus. Vitae nunc sed velit dignissim sodales ut eu. Diam phasellus vestibulum lorem sed risus. Volutpat ac tincidunt vitae semper quis lectus nulla. Enim neque volutpat ac tincidunt vitae semper quis. Sit amet consectetur adipiscing elit ut aliquam purus sit. Etiam erat velit scelerisque in dictum non consectetur. At lectus urna duis convallis convallis.", "\\Images\\thumbnails\\EthernetCableGreenThumbnail.jpg", "\\Images\\EthernetCableGreen.jpg", true, true, "Ethernet Cable Green", 15.00m },
                    { 12, 3, "Orci dapibus ultrices in iaculis. Nec nam aliquam sem et tortor consequat. Neque convallis a cras semper auctor neque vitae. Augue neque gravida in fermentum et sollicitudin. Odio aenean sed adipiscing diam donec adipiscing tristique risus nec. Turpis egestas integer eget aliquet nibh praesent tristique magna sit. ", "\\Images\\thumbnails\\HDMI_to_Micro_thumbnail.jpg", "\\Images\\HDMI_to_Micro.jpg", true, true, "Ethernet Cable Green", 10.00m },
                    { 13, 3, "Mauris rhoncus aenean vel elit scelerisque mauris. Rutrum tellus pellentesque eu tincidunt tortor aliquam nulla facilisi. Scelerisque fermentum dui faucibus in ornare. Quis lectus nulla at volutpat. Ipsum consequat nisl vel pretium.", "\\Images\\thumbnails\\320px-Power_cord_(817840840).jpg", "\\Images\\800px-Power_cord_(817840840).jpg", true, false, "Power cord", 10.00m },
                    { 14, 3, "In vitae turpis massa sed elementum. Elementum nibh tellus molestie nunc non. Ultrices eros in cursus turpis massa. At erat pellentesque adipiscing commodo. Cras adipiscing enim eu turpis egestas pretium aenean pharetra. Vivamus at augue eget arcu dictum varius duis at. Vitae justo eget magna fermentum iaculis eu non diam. Mattis enim ut tellus elementum sagittis vitae et leo. Sit amet risus nullam eget felis eget. Ipsum nunc aliquet bibendum enim facilisis gravida neque convallis a. Sem nulla pharetra diam sit.", "\\Images\\thumbnails\\218px-Cable-ecran-VGA.jpg", "\\Images\\Cable-ecran-VGA.jpg", true, true, "VGA Cable", 20.00m },
                    { 15, 3, "Egestas fringilla phasellus faucibus scelerisque eleifend. Massa id neque aliquam vestibulum morbi blandit cursus risus at. Sem nulla pharetra diam sit amet nisl suscipit adipiscing. Vitae elementum curabitur vitae nunc sed. Nunc eget lorem dolor sed viverra ipsum nunc aliquet. Consectetur lorem donec massa sapien faucibus et molestie ac feugiat. ", "\\Images\\thumbnails\\320px-Serial_Cable_thumbnail.jpg", "\\Images\\Serial_Cable.jpg", true, true, "Serial Cable", 20.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "HardwareId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "HardwareId",
                table: "Hardwares",
                newName: "HardWareId");
        }
    }
}

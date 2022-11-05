using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } 
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Computing" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Audio" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cables" });

            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 1,
                Name = "Toshiba HD-A1 motherboard 20081026",
                Price = 10.00M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "\\Images\\Toshiba_HD-A1_motherboard_20081026.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\209px-Toshiba_HD-A1_motherboard_20081026.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 2,
                Name = "Intel CPU Core i7 6700K Skylake perspective",
                Price = 50.00M,
                Description = "Pellentesque nec dolor sed ante dictum pretium. Ut aliquam augue sem, a rutrum elit fermentum vel. Sed interdum ligula tincidunt erat ornare hendrerit. Fusce sed semper est. In rhoncus luctus laoreet. Mauris venenatis pellentesque mi quis aliquam.",
                CategoryId = 1,
                ImageUrl = "\\Images\\800px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 3,
                Name = "Early Apple Macintosh with keyboard and mouse",
                Price = 85.00M,
                Description = "Phasellus at ex vitae tortor laoreet viverra sed sed leo. Nulla congue ex id pretium consequat. Integer quis eleifend tellus. Proin id dapibus urna, et efficitur metus. Pellentesque accumsan gravida nulla ut cursus. Integer sit amet fringilla eros. Duis lacinia tincidunt ultrices.",
                CategoryId = 1,
                ImageUrl = "\\Images\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum_thumbnail.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 4,
                Name = "D-Link DES-1024R+-91906",
                Price = 100.00M,
                Description = "Praesent ornare velit tempus ornare bibendum. Donec gravida mi sed tincidunt pharetra. Sed ut purus vel nisi tincidunt fermentum sit amet sed orci. Sed consequat nisi id urna imperdiet ullamcorper. Phasellus bibendum lobortis risus, eget placerat justo sollicitudin et.",
                CategoryId = 1,
                ImageUrl = "\\Images\\D-Link_DES-1024R91906.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-D-Link_DES-1024R91906.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 5,
                Name = "Vertex 2 Solid State Drive by OCZ top oblique PNr°0307",
                Price = 65.00M,
                Description = "Sed et turpis efficitur, dictum massa eget, rutrum sapien. Praesent faucibus elit ac dictum consectetur. Mauris sagittis at est vel finibus. Nam at nisi eros. Etiam massa erat, fermentum lobortis pellentesque et, blandit eget turpis. Ut fermentum leo non nisl ullamcorper scelerisque. Maecenas feugiat nunc eros, sed convallis ex dapibus id. Proin vitae dolor ut est dictum condimentum. Morbi ut rutrum lectus, quis suscipit libero. Vestibulum aliquam neque ut augue vestibulum lacinia.",
                CategoryId = 1,
                ImageUrl = "\\Images\\Vertex_2_Solid_State_Drive.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Vertex_2_Solid_State_Drive.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 6,
                Name = "Marshall JCM800 amplifier",
                Price = 195.00M,
                Description = "Quisque posuere vehicula libero eu porttitor. Sed et nunc nunc. Nulla elit tellus, interdum a neque ac, eleifend rutrum lorem. Mauris rhoncus, lorem nec posuere maximus, mi justo rhoncus neque, ut vestibulum felis ex non arcu. Aenean non mi sem. Pellentesque a congue quam.",
                CategoryId = 2,
                ImageUrl = "\\Images\\Marshall_JCM800_amplifier.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\180px-Marshall_JCM800_amplifier.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 7,
                Name = "Circumaural headphones",
                Price = 25.00M,
                Description = "At erat pellentesque adipiscing commodo elit at imperdiet. Diam vulputate ut pharetra sit. Cras tincidunt lobortis feugiat vivamus at. In nibh mauris cursus mattis molestie a iaculis at erat. Purus sit amet luctus venenatis lectus magna fringilla urna. Morbi tristique senectus et netus. Phasellus egestas tellus rutrum tellus pellentesque eu tincidunt tortor. Amet tellus cras adipiscing enim eu. Nunc sed blandit libero volutpat sed cras ornare arcu dui.",
                CategoryId = 2,
                ImageUrl = "\\Images\\Headphones_1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Headphones_1.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 8,
                Name = "Minimoog sympthesiser",
                Price = 135.00M,
                Description = "Quisque non bibendum lectus. Proin tempor pulvinar lobortis. Proin auctor lorem vitae felis volutpat feugiat. Cras egestas diam a risus elementum, at semper turpis placerat. Sed molestie vulputate tellus. Mauris et massa elementum, lobortis velit nec, consequat risus. Nullam vel mi vitae nunc mattis ullamcorper.",
                CategoryId = 2,
                ImageUrl = "\\Images\\R.A.Moog_minimoog_2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-R.A.Moog_minimoog_2.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 9,
                Name = "Turntables and mixer",
                Price = 170.00M,
                Description = "Donec et dapibus erat, vitae tempus mauris. Duis cursus viverra metus, volutpat consequat quam rutrum nec. Nam massa ante, iaculis quis nunc sit amet, suscipit tristique massa. Aliquam posuere rutrum felis, vitae condimentum lectus lobortis eget. Aenean dignissim tempor ex, id tempus augue mattis et. Vestibulum ac fermentum risus, ac vulputate odio.",
                CategoryId = 2,
                ImageUrl = "\\Images\\Turntables_and_mixer.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Turntables_and_mixer.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 10,
                Name = "Vox Tone Bender",
                Price = 65.00M,
                Description = "Fusce lacinia augue eget felis rutrum, fringilla condimentum tellus mattis. Donec vitae sapien sit amet ligula molestie sagittis. In dignissim lacus in risus lobortis, quis varius est gravida. Integer in massa imperdiet, mattis turpis sed, laoreet risus. In a enim condimentum, facilisis diam vitae, eleifend mauris.",
                CategoryId = 2,
                ImageUrl = "\\Images\\800px-Vox_Tone_Bender.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Vox_Tone_Bender.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 11,
                Name = "Ethernet Cable Green",
                Price = 15.00M,
                Description = "Turpis egestas integer eget aliquet nibh. Viverra justo nec ultrices dui. Cum sociis natoque penatibus et magnis dis parturient montes nascetur. Tincidunt dui ut ornare lectus. Vitae nunc sed velit dignissim sodales ut eu. Diam phasellus vestibulum lorem sed risus. Volutpat ac tincidunt vitae semper quis lectus nulla. Enim neque volutpat ac tincidunt vitae semper quis. Sit amet consectetur adipiscing elit ut aliquam purus sit. Etiam erat velit scelerisque in dictum non consectetur. At lectus urna duis convallis convallis.",
                CategoryId = 3,
                ImageUrl = "\\Images\\EthernetCableGreen.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\EthernetCableGreenThumbnail.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 12,
                Name = "Ethernet Cable Green",
                Price = 10.00M,
                Description = "Orci dapibus ultrices in iaculis. Nec nam aliquam sem et tortor consequat. Neque convallis a cras semper auctor neque vitae. Augue neque gravida in fermentum et sollicitudin. Odio aenean sed adipiscing diam donec adipiscing tristique risus nec. Turpis egestas integer eget aliquet nibh praesent tristique magna sit. ",
                CategoryId = 3,
                ImageUrl = "\\Images\\HDMI_to_Micro.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\HDMI_to_Micro_thumbnail.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 13,
                Name = "Power cord",
                Price = 10.00M,
                Description = "Mauris rhoncus aenean vel elit scelerisque mauris. Rutrum tellus pellentesque eu tincidunt tortor aliquam nulla facilisi. Scelerisque fermentum dui faucibus in ornare. Quis lectus nulla at volutpat. Ipsum consequat nisl vel pretium.",
                CategoryId = 3,
                ImageUrl = "\\Images\\800px-Power_cord_(817840840).jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Power_cord_(817840840).jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 14,
                Name = "VGA Cable",
                Price = 20.00M,
                Description = "In vitae turpis massa sed elementum. Elementum nibh tellus molestie nunc non. Ultrices eros in cursus turpis massa. At erat pellentesque adipiscing commodo. Cras adipiscing enim eu turpis egestas pretium aenean pharetra. Vivamus at augue eget arcu dictum varius duis at. Vitae justo eget magna fermentum iaculis eu non diam. Mattis enim ut tellus elementum sagittis vitae et leo. Sit amet risus nullam eget felis eget. Ipsum nunc aliquet bibendum enim facilisis gravida neque convallis a. Sem nulla pharetra diam sit.",
                CategoryId = 3,
                ImageUrl = "\\Images\\Cable-ecran-VGA.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\218px-Cable-ecran-VGA.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 15,
                Name = "Serial Cable",
                Price = 20.00M,
                Description = "Egestas fringilla phasellus faucibus scelerisque eleifend. Massa id neque aliquam vestibulum morbi blandit cursus risus at. Sem nulla pharetra diam sit amet nisl suscipit adipiscing. Vitae elementum curabitur vitae nunc sed. Nunc eget lorem dolor sed viverra ipsum nunc aliquet. Consectetur lorem donec massa sapien faucibus et molestie ac feugiat. ",
                CategoryId = 3,
                ImageUrl = "\\Images\\Serial_Cable.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Serial_Cable_thumbnail.jpg",
                IsInStock = true,
                IsOnSale = true
            });
        }
    }
}


using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your address")]
        [Display(Name = "Street")]
        [StringLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "Enter your town or city")]
        [Display(Name = "Town or City")]
        public string TownOrCity { get; set; }

        [Required(ErrorMessage = "Enter your county")]
        [StringLength(100)]
        public string County { get; set; }

        [Required(ErrorMessage = "Enter your postcode")]
        [StringLength(7, MinimumLength = 5)]
        [Display(Name = "Postcode")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}

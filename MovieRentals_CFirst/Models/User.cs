using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRentals_CFirst.Models
{
    public class User
    {
        public User()
        {
            this.Type = "User";
            //this.CartItems = new HashSet<CartItem>();
            //this.Orders = new HashSet<Order>();
            //this.OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email pattern doesn't match")]
        public string EmailId { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]

        [Compare("Password", ErrorMessage = "Please match your password")]
        public string ConfirmPassword { get; set; }

        public string Type { get; set; }
        public string Gender { get; set; }

        [Range(18, 100, ErrorMessage = "Age should be greater than 18")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public Nullable<decimal> Phone { get; set; }
        public string Address { get; set; }
    }
}
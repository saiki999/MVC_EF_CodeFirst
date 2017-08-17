using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRentals_CFirst.Models
{
    public class Movie
    {
        [Required][Key]
        public int ID { get; set; }

        [Required]
        [StringLength(60,MinimumLength=2)]
        public string Title { get; set; }

       [Range(1,5)]
       
        public int Rating { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        [DataType(DataType.Date)]
       
        public DateTime DateOfRelease { get; set; }

        [Required]
        [StringLength(50)]
        public string Genere { get; set; }

        [Required]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Range(1,1000)]
        
        public double Quantity { get; set; }

    }
}
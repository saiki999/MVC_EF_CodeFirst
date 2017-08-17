using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieRentals_CFirst.Models;

namespace MovieRentals_CFirst.Models
{
    public class MovieRental_CfDBContext:DbContext
    {

        public DbSet<Movie> Movies  { get; set; }

        public System.Data.Entity.DbSet<MovieRentals_CFirst.Models.User> Users { get; set; }
    }
}
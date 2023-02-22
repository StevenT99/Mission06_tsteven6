using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_tsteven6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, Categoryname = "Action" },
                new Category { CategoryId = 2, Categoryname = "Animation"},
                new Category { CategoryId = 3, Categoryname = "Comedy" },
                new Category { CategoryId = 4, Categoryname = "Crime" },
                new Category { CategoryId = 5, Categoryname = "Drama" },
                new Category { CategoryId = 6, Categoryname = "Fantasy" },
                new Category { CategoryId = 7, Categoryname = "Historical" },
                new Category { CategoryId = 8, Categoryname = "Horror" },
                new Category { CategoryId = 9, Categoryname = "Romance" },
                new Category { CategoryId = 10, Categoryname = "Science Fiction" },
                new Category { CategoryId = 11, Categoryname = "Thriller" },
                new Category { CategoryId = 12, Categoryname = "Western" },
                new Category { CategoryId = 13, Categoryname = "Sports" },
                new Category { CategoryId = 14, Categoryname = "Other" }

                );
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 5,
                    Title = "Shawshank Redemption",
                    Year = 1994,
                    Director = "Frank Darabont",
                    Rating = "R",
                    Edited = true,
                    Lent = "Steve",
                    Notes = "Steve loves this movie man"

                  
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 5,
                    Title = "Whiplash",
                    Year = 2014,
                    Director = "Damien Chazelle",
                    Rating = "R",
                    Edited = true,
                    Lent = "Steve",
                    Notes = "Steve loves this movie as well man"


                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 13,
                    Title = "Creed",
                    Year = 2015,
                    Director = "Frank Darabont",
                    Rating = "PG-13",
                    Edited = true,
                    Lent = "Steve",
                    Notes = "Steve loves this movie a lot man"


                }
                );
        }
    }
}

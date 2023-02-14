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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Drama/Crime",
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
                    Category = "Drama/Music",
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
                    Category = "Sport/Drama",
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

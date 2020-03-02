using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Religion",
                        Rating = "PG",
                        Price = 7.99M,
                        Img = "rm.jpg"
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Religion",
                        Rating = "PG",
                        Price = 8.99M,
                        Img = "heaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Religion",
                        Rating = "PG",
                        Price = 9.99M,
                        Img = "meet.jpg"
                    },

                    new Movie
                    {
                        Title = "Saratov",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Religion",
                        Rating = "PG",
                        Price = 3.99M,
                        Img = "saratov.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
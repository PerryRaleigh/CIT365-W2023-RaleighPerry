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
                        Title = "Once I Was a Beehive",
                        ReleaseDate = DateTime.Parse("2015-08-14"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 1.00M,
                        ImageFileName = "OnceIWasABeehive.jpg"
                    },

                    new Movie
                    {
                        Title = "Love, Kennedy",
                        ReleaseDate = DateTime.Parse("2017-06-02"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 1.00M,
                        ImageFileName = "LoveKennedy.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 3.99M,
                        ImageFileName = "MeetTheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "Witnesses",
                        ReleaseDate = DateTime.Parse("2021-06-04"),
                        Genre = "Docudrama",
                        Rating = "PG",
                        Price = 3.99M,
                        ImageFileName = "Witnesses.jpg"
                    },

                    new Movie
                    {
                        Title = "Once I Was Engaged",
                        ReleaseDate = DateTime.Parse("2021-06-21"),
                        Genre = "Comedy",
                        Rating = "Not Rated",
                        Price = 3.99M,
                        ImageFileName = "IOnceWasEngaged.jpg"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-01"),
                        Genre = "Drama/Action",
                        Rating = "PG-13",
                        Price = 3.99M,
                        ImageFileName = ""
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-07-24"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 1.00M,
                        ImageFileName = "TheSaratovApproach.jpg"
                    },

                    new Movie
                    {
                        Title = "Out Of Liberty",
                        ReleaseDate = DateTime.Parse("2019-09-13"),
                        Genre = "Western/Drama",
                        Rating = "PG",
                        Price = 1.00M,
                        ImageFileName = "OutOfLiberty.jpg"
                    },

                    new Movie
                    {
                        Title = "Jane and Emma",
                        ReleaseDate = DateTime.Parse("2018-10-12"),
                        Genre = "Drama/History",
                        Rating = "PG",
                        Price = 1.99M,
                        ImageFileName = "JaneAndEmma.jpg"
                    },

                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-05-31"),
                        Genre = "Drama/History",
                        Rating = "PG",
                        Price = 1.99M,
                        ImageFileName = "EphraimsRescue.jpg"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-09-11"),
                        Genre = "War/Action",
                        Rating = "PG-13",
                        Price = 5.99M,
                        ImageFileName = "SaintsAndSoldiers.jpg"
                    },

                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-01-01"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 3.99M,
                        ImageFileName = "Charly.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                  
                    new Movie
                    {
                        Artist = "10cc",
                        Title = "The Original Soundtrack",
                        Genre = "Rock/Popular",
                        Format = "Stereo",
                        Label = "Mercury",
                        CatNumber = "6310 500"
                    },

                    new Movie
                    {
                        Artist = "10cc",
                        Title = "Deceptive Bends",
                        Genre = "Rock/Popular",
                        Format = "Stereo",
                        Label = "Mercury",
                        CatNumber = "6310 502"
                    },

                    new Movie
                    {
                        Artist = "10cc",
                        Title = "How Dare You",
                        Genre = "Rock/Popular",
                        Format = "Stereo",
                        Label = "Mercury",
                        CatNumber = "MIP-1-9316"
                    },

                      new Movie
                    {
                        Artist = "10cc",
                        Title = "Bloody Tourists",
                        Genre = "Rock/Popular",
                        Format = "Stereo",
                        Label = "Polydor, Man Ken Records, Polydor",
                        CatNumber = "PD-1-6161, 2480 477"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
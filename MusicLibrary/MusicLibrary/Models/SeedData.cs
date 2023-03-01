using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;

namespace MusicLibrary.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MusicLibraryContext(serviceProvider.GetRequiredService<DbContextOptions<MusicLibraryContext>>()))
        {
            if (context == null || context.Song == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Song.Any())
            {
                return; // DB has already been seeded
            }

            context.Song.AddRange(
                new Song
                {
                    Title = "Wish You Were Here",
                    ReleaseDate = DateTime.Parse("02/09/1975"),
                    Genre = "Progressive Rock",
                    Artist = "Pink Floyd",
                    Album = "Wish You Were Here"

                },
                new Song
                {
                    Title = "Shine On You Crazy Diamond",
                    ReleaseDate = DateTime.Parse("02/09/1975"),
                    Genre = "Progressive Rock",
                    Artist = "Pink Floyd",
                    Album = "Wish You Were Here"

                },
                new Song
                {
                    Title = "Welcome to the Machine",
                    ReleaseDate = DateTime.Parse("02/09/1975"),
                    Genre = "Progressive Rock",
                    Artist = "Pink Floyd",
                    Album = "Wish You Were Here"

                },
                new Song
                {
                    Title = "Have a Cigar",
                    ReleaseDate = DateTime.Parse("02/09/1975"),
                    Genre = "Progressive Rock",
                    Artist = "Pink Floyd",
                    Album = "Wish You Were Here"

                },

                new Song
                {
                    Title = "Clair de Lune",
                    ReleaseDate = DateTime.Parse("04/12/1974"),
                    Genre = "Classical",
                    Artist = "Isao Tomita",
                    Album = "Snowflakes Are Dancing"
                },
                new Song
                {
                    Title = "Reverie",
                    ReleaseDate = DateTime.Parse("04/12/1974"),
                    Genre = "Classical",
                    Artist = "Isao Tomita",
                    Album = "Snowflakes Are Dancing"
                },
                new Song
                {
                    Title = "Gardens in the Rain",
                    ReleaseDate = DateTime.Parse("04/12/1974"),
                    Genre = "Classical",
                    Artist = "Isao Tomita",
                    Album = "Snowflakes Are Dancing"
                },
                new Song
                {
                    Title = "Arabesque No. 1",
                    ReleaseDate = DateTime.Parse("04/12/1974"),
                    Genre = "Classical",
                    Artist = "Isao Tomita",
                    Album = "Snowflakes Are Dancing"
                },
                new Song
                {
                    Title = "Radio GaGa",
                    ReleaseDate = DateTime.Parse("01/16/1984"),
                    Genre="Pop Rock",
                    Artist="Queen",
                    Album="The Works"
                },
                new Song
                {
                    Title = "Hammer to Fall",
                    ReleaseDate = DateTime.Parse("01/16/1984"),
                    Genre = "Pop Rock",
                    Artist = "Queen",
                    Album = "The Works"
                },
                new Song
                {
                    Title= "Big Iron",
                    ReleaseDate = DateTime.Parse("02/22/1960"),
                    Genre="Country",
                    Artist="Marty Robbins",
                    Album = "Gunfighter Ballads and Trail Songs"
                }

           );
            context.SaveChanges();
                


        }
    }

}

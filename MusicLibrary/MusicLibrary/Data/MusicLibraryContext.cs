using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models;

namespace MusicLibrary.Data
{
    public class MusicLibraryContext : DbContext
    {
        public MusicLibraryContext (DbContextOptions<MusicLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<MusicLibrary.Models.Song> Song { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Models;

namespace MusicLibrary.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly MusicLibrary.Data.MusicLibraryContext _context;

        public IndexModel(MusicLibrary.Data.MusicLibraryContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from s in _context.Song
                                            orderby s.Genre
                                            select s.Genre;
            


            var songs = from s in _context.Song
                        select s;

            if (!string.IsNullOrEmpty(SongArtist))
            {
                songs = songs.Where(s => s.Artist.Contains(SongArtist));
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                songs = songs.Where(s => s.Title.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(SongAlbum))
            {
                songs = songs.Where(s => s.Album.Contains(SongAlbum));

            }



            if (!string.IsNullOrEmpty(SongGenre))
            {
                songs = songs.Where(s => s.Genre.Contains(SongGenre));
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Song = await songs.ToListAsync();

            
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SongGenre { get; set; }

        [BindProperty(SupportsGet =true)]
        public string? SongArtist { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SongAlbum { get; set;}

        

        
    }
}

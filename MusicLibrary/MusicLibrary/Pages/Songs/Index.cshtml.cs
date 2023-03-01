using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            if (_context.Song != null)
            {
                Song = await _context.Song.ToListAsync();
            }
        }
    }
}

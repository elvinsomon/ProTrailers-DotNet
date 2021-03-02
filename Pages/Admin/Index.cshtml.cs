using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProTrailers.Data;
using ProTrailers.Models;

namespace ProTrailers.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly ProTrailers.Data.ProTrailersContext _context;

        public IndexModel(ProTrailers.Data.ProTrailersContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}

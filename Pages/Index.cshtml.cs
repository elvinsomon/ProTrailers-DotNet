﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProTrailers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTrailers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProTrailers.Data.ProTrailersContext _context;

        public IndexModel(ProTrailers.Data.ProTrailersContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        public string filtroBusqueda { get; set; }

        public async Task OnGetAsync(string busqueda)
        {
            filtroBusqueda = busqueda;

            IQueryable<Movie> movieIQ = from s in _context.Movies
                                             select s;

            if (!String.IsNullOrEmpty(busqueda))
            {
                movieIQ = movieIQ.Where(s => s.Titulo.Contains(busqueda)
                                       || s.Director.Contains(busqueda));
            }

            Movie = await movieIQ.AsNoTracking().ToListAsync();

        }
    }
}

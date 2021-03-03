using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProTrailers.Models;
using ProTrailers.Areas.Identity.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTrailers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly ProTrailers.Data.ProTrailersContext _context;
        public IndexModel(UserManager<IdentityUser> userManager, ProTrailers.Data.ProTrailersContext context)
        {
            this.userManager = userManager;
            _context = context;
        }



        public Pagination<Movie> Movies { get; set; }
        public string filtroBusqueda { get; set; }


        public async Task OnGetAsync(string busqueda, int? pageIndex)
        {
            if(busqueda != null)
            {
                pageIndex = 1;
            }
            else
            {
                busqueda = filtroBusqueda;
            }

            filtroBusqueda = busqueda;

            IQueryable<Movie> movieIQ = from s in _context.Movies
                                             select s;

            if (!String.IsNullOrEmpty(busqueda))
            {
                movieIQ = movieIQ.Where(s => s.Titulo.Contains(busqueda)
                                       || s.Director.Contains(busqueda));
            }

            //Movies = await movieIQ.AsNoTracking().ToListAsync();

            int sizePage = 6;
            Movies = await Pagination<Movie>.CreateAsync(movieIQ.AsNoTracking(), pageIndex ?? 1, sizePage);

        }
    }
}

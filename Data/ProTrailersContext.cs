using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProTrailers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTrailers.Data
{
    public class ProTrailersContext: IdentityDbContext
    {
        public ProTrailersContext (DbContextOptions<ProTrailersContext> options) 
            : base(options)
        { 

        }

        public DbSet<Movie> Movies { get; set; }
    }
}

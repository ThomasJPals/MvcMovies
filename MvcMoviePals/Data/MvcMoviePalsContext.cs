using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMoviePals.Models;

namespace MvcMoviePals.Data
{
    public class MvcMoviePalsContext : DbContext
    {
        public MvcMoviePalsContext (DbContextOptions<MvcMoviePalsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMoviePals.Models.Movie> Movie { get; set; }
    }
}

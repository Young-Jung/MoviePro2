using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MoviePro2.Models;

namespace MoviePro2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<MoviePro2.Models.Movie> Movie { get; set; }
        public DbSet<MoviePro2.Models.Cast> Cast { get; set; }
        public DbSet<MoviePro2.Models.Crew> Crew { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JoelMovieAPI.Models
{
    public partial class JoelHiltonMovieCollectionContext : DbContext
    {
        //public JoelHiltonMovieCollectionContext()
        //{
        //}

        public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options)
            : base(options) { }
        

        public virtual DbSet<Movie> Movies { get; set; } 

        
    }
}

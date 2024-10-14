using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AlbumReview.Models;

public class DatabaseContext : DbContext
{

    public DbSet<Album> Albums { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<AlbumGenre> AlbumGenres { get; set; }  

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Album>()
        .HasMany(a => a.Genres)
        .WithMany(g => g.Albums)
        .UsingEntity<AlbumGenre>(
            ag => ag.HasOne<Genre>().WithMany().HasForeignKey(ag => ag.GenreId),
            ag => ag.HasOne<Album>().WithMany().HasForeignKey(ag => ag.AlbumId),
            ag => ag.HasKey(t => new { t.AlbumId, t.GenreId })
        );
    }
}
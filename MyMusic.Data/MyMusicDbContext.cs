using Microsoft.EntityFrameworkCore;
using MyMusic.Data.Configuration;
using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MysMusic.Core.Models;

namespace MyMusic.Data
{
    public class MyMusicDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<UserArtiste> Users { get; set; }

        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options)
       : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MusicConfiguration());

            builder.ApplyConfiguration(new ArtistConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

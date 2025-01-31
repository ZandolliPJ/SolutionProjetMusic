﻿using Microsoft.EntityFrameworkCore;
using MysMusic.Core.Models;
using MysMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.Repositories
{
    public class userRepository :Repository<Artist>,IArtistRepository
    {
        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }
        public userRepository(MyMusicDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Artist>> GetAllWithMusicsAsync()
        {
            return await MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .ToListAsync();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            return MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        async Task<IEnumerable<Artist>> IArtistRepository.GetAllWithMusicsAsync()
        {
            return await MyMusicDbContext.Artists
              .Include(a => a.Musics)
              .ToListAsync();
        }

        Task<Artist> IArtistRepository.GetWithMusicsByIdAsync(int id)
        {
            return MyMusicDbContext.Artists
          .Include(a => a.Musics)
         .SingleOrDefaultAsync(a => a.Id == id);
        }

   
    }
}

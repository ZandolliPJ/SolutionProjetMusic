﻿using MysMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MysMusic.Core.Repositories
{
    public interface IArtistRepository :IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}

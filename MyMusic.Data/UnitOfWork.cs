﻿using MyMusic.Core.Repositories;
using MyMusic.Data.Repositories;
using MysMusic.Core;
using MysMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyMusicDbContext _context;
        private IMusicRepository _musicRepository;
        private IArtistRepository _artistRepository;
        private IUserRepository _userRepository;
        public UnitOfWork(MyMusicDbContext context)
        {
            this._context = context;
        }
        public IMusicRepository Musics => _musicRepository = _musicRepository ?? new MusicRepository(_context);

        public IArtistRepository Artists => _artistRepository = _artistRepository ?? new userRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

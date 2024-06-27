using MyMusic.Core.Models;
using MysMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Services
{
    public interface IUserService
    {
        Task<UserArtiste> Authenticate(string username, string password);
        Task<IEnumerable<UserArtiste>> GetAll();
        Task<UserArtiste> GetById(int id);
        Task<UserArtiste> Create(UserArtiste user, string password);
        void Update(UserArtiste user, string password = null);
        void Delete(int id);
    }
}

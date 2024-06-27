using MysMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace MyMusic.Core.Repositories
{
    public interface IUserRepository
    {
        Task<UserArtiste> Authenticate(string username, string password);
        Task<UserArtiste> Create(UserArtiste user, string password);
        void Update(UserArtiste user, string password = null);
        void Delete(int id);
        Task<IEnumerable<UserArtiste>> GetAllUserAsync();
        Task<UserArtiste> GetWithUsersByIdAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MysMusic.Core;
using MysMusic.Core.Models;
using MysMusic.Core.Services;
using System.Threading.Tasks;
using MyMusic.Core.Services;

namespace MyMusic.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<UserArtiste> Authenticate(string username, string password)
        {
            return await _unitOfWork.Users.Authenticate(username, password);
        }

        public async Task<UserArtiste> Create(UserArtiste user, string password)
        {
            await _unitOfWork.Users.Create(user, password);

            await _unitOfWork.CommitAsync();
            return user;
        }

        public void Delete(int id)
        {
            _unitOfWork.Users.Delete(id);
            _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<UserArtiste>> GetAll()
        {
            return await _unitOfWork.Users.GetAllUserAsync();
        }

        public async Task<UserArtiste> GetById(int id)
        {
            return await _unitOfWork.Users.GetWithUsersByIdAsync(id);
        }

        public void Update(UserArtiste user, string password = null)
        {
            _unitOfWork.Users.Update(user, password);
            _unitOfWork.CommitAsync();
        }

    }
}

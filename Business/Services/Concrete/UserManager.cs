using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using BCrypt.Net;

namespace Business.Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Register(RegisterDTO dto)
        {
            var user = new User
            {
                Email = dto.Email,
                CompanyId = dto.CompanyId,
                Role = dto.Role,
                IsActive = true,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            _userDal.Add(user);
        }

        public LoginDTO Login(string email, string password)
        {
            var user = _userDal.Get(x => x.Email == email && x.IsActive);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return new LoginDTO
                {
                    UserId = user.Id,
                    Email = user.Email,
                    Role = user.Role,
                    CompanyId = user.CompanyId
                };
            }

            return null;
        }

        public void ResetPassword(ResetPasswordDTO dto)
        {
            var user = _userDal.Get(x => x.Email == dto.Email && x.IsActive);
            if (user != null)
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);
                _userDal.Update(user);
            }
        }

        public User GetById(int id)
        {
            return _userDal.Get(x => x.Id == id);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll().ToList();
        }

        public List<User> GetByCompanyId(int companyId)
        {
            return _userDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public void ChangeRole(int userId, string newRole)
        {
            var user = _userDal.Get(x => x.Id == userId);
            if (user != null)
            {
                user.Role = newRole;
                _userDal.Update(user);
            }
        }

        public bool CheckPassword(int userId, string password)
        {
            var user = _userDal.Get(x => x.Id == userId);
            if (user == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        public void UpdatePassword(int userId, string newPassword)
        {
            var user = _userDal.Get(x => x.Id == userId);
            if (user != null)
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                _userDal.Update(user);
            }
        }
    }
}

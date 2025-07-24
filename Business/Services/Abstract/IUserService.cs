using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Services.Abstract
{
    public interface IUserService
    {
        void Register(RegisterDTO dto);
        LoginDTO Login(string email, string password);
        void ResetPassword(ResetPasswordDTO dto);

        User GetById(int id);
        User GetByEmail(string email);
        List<User> GetAll();

        List<User> GetByCompanyId(int companyId);
        void ChangeRole(int userId, string newRole);
        bool CheckPassword(int userId, string password);
        void UpdatePassword(int userId, string newPassword);
    }
}

using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserProvider
    {
        User CreateUser(string email, string password);

        IQueryable<User> GetAllUsers();
        Task<User> CreateUserAsync(string email, string password);
        int CountUsers { get; }
    }
}

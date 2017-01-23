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
<<<<<<< HEAD
        User CreateUser(string email, string password);

=======
        IQueryable<User> GetAllUsers();
        User CreateUser(string email, string password);
        Task<User> CreateUserAsync(string email, string password);
        int CountUsers { get; }
>>>>>>> c21f9b55fe1a2cc3fae3a068b96563554a528dac
    }
}

using DAL.Abstract;
using DAL.Entities;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using System.Diagnostics;
using System.Threading;

namespace DAL.Concrete
{
    public class UserProvider : IUserProvider
    {
        EfContext mContext;
        public UserProvider()
        {
            mContext = new EfContext();
        }

        
        public int CountUsers
        {
            get
            {
                return mContext.Users.Count();
            }
        }

        public User CreateUser(string email, string password)
        {
            Debug.WriteLine("Provider pool ID" + Thread.CurrentThread.ManagedThreadId.ToString());
            User user = new User
            {
                Username = email,
                Password = password,
                PasswordSalt = "hello"
            };
            mContext.Users.Add(user);
            mContext.SaveChanges();
            return user;
        }

        public Task<User> CreateUserAsync(string email, string password)
        {
            return Task.Run(() => CreateUser(email,password));
        }

        public IQueryable<User> GetAllUsers()
        {
            return mContext.Users;
        }
    }
}

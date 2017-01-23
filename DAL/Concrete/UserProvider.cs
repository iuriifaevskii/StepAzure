using DAL.Abstract;
<<<<<<< HEAD
using DAL.Entities;
=======
>>>>>>> c21f9b55fe1a2cc3fae3a068b96563554a528dac
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using DAL.Entities;
using System.Diagnostics;
using System.Threading;
>>>>>>> c21f9b55fe1a2cc3fae3a068b96563554a528dac

namespace DAL.Concrete
{
    public class UserProvider : IUserProvider
    {
        EfContext mContext;
        public UserProvider()
        {
            mContext = new EfContext();
        }

<<<<<<< HEAD
        public User CreateUser(string email, string password)
        {
            User user = new User
            {
                Username = email,
                Password = password

            };
            mContext.Users.Add(user);
            mContext.SaveChanges();

            return user;
        }

=======
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
                Username=email,
                Password=password
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
>>>>>>> c21f9b55fe1a2cc3fae3a068b96563554a528dac
    }
}

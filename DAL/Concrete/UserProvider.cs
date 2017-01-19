using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Concrete
{
    public class UserProvider : IUserProvider
    {
        EfContext mContext;
        public UserProvider()
        {
            mContext = new EfContext();
        }
        public User CreateUser(string email, string password)
        {
            User user = new User
            {
                Username=email,
                Password=password
            };
            mContext.Users.Add(user);
            mContext.SaveChanges();
            return user;
        }
    }
}

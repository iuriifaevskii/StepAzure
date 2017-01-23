using DAL.Abstract;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Username = email,
                Password = password

            };
            mContext.Users.Add(user);
            mContext.SaveChanges();

            return user;
        }

    }
}

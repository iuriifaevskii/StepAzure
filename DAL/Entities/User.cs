using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public User() 
        {
            this.Roles = new HashSet<Role>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, StringLength(maximumLength: 200)]
        public string Password { get; set; }
        [Required, StringLength(maximumLength: 200)]
        public string PasswordSalt { get; set; }

        public virtual ICollection<Wish> Wishes { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

    }
}

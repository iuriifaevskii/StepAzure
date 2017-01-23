using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Role
    {
        public Role() 
        {
            this.Users = new HashSet<User>();
        }
        [Key]
        public int Id {get;set;}
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Cart
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        public int UserId { get; set; }
    
        public User User { get; set; }

        public virtual IEnumerable<CartItem> Items { get; set; }
    
    }
}

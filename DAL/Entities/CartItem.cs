using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }
    }
}

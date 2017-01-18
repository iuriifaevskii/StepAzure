﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Product
    {
        [Key]
        public int Id { get; set; }
       
        [Required, StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Wish> Wishes { get; set; }

    }
}

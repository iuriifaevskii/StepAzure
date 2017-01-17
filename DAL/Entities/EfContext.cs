using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EfContext:DbContext
    {
        public EfContext()
            : base("MyAzureDb")
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}

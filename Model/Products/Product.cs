using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Products
{
    public class Product : Entity<int>
    {
        public virtual String Name { get; set; }
        public virtual decimal Price { get; set; }       
    }
}

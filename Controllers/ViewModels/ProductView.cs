using Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controllers.ViewModels
{
    public class ProductView
    {
        public IEnumerable<Product> productList { get; set; }
    }
}
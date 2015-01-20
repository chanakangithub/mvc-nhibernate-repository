using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}

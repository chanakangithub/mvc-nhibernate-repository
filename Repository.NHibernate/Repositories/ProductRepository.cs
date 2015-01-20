using Infrastructure.UnitOfWork;
using Model.Products;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.NHibernate.Repositories
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}

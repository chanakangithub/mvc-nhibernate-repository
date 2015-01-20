using Controllers.ViewModels;
using Infrastructure.UnitOfWork;
using Model.Products;
using Repository.NHibernate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Mvc;

namespace Controllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _uow;
        public HomeController(IUnitOfWork uow, IProductRepository productRepository)
        {
            _uow = uow;
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            ProductView model = new ProductView();
            model.productList = _productRepository.FindAll().ToList();
            return View(model);
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Data.Common.Automapper;
using Store.Data.Common.Repositories;
using Store.Data.Common.ViewModels;

namespace Store.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IStoreContextData Context { get; }
        public ProductsController(IStoreContextData db)
        {
            Context = db;
        }
        public IActionResult Index()
        {
            var res=MapperConfigurator.Mapper.Map<List<ProductViewModel>>(Context.Products.All());
            
            return View(res);
        }
    }
}
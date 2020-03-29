using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Store.Data.Common.Automapper;
using Store.Data.Common.Repositories;
using Store.Data.Common.ViewModels;
using Store.Models;

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
            //Automapper library
            
            var res=MapperConfigurator.Mapper.Map<List<ProductViewModel>>(Context.Products.All());
            
            return View(res);
        }
        public IActionResult Add(ProductViewModel model)
        {
            bool isAjaxCall = Request.Headers["x-requested-with"] == "XMLHttpRequest";

            if (ModelState.IsValid)
            {
                var res = MapperConfigurator.Mapper.Map<Product>(model);
              
                this.Context.Products.Add(res);
                this.Context.SaveChanges();
                if (isAjaxCall)
                {
                    var id = res.Id;
                    return Json(JsonConvert.SerializeObject(model));
                }
                return View("Index");
            }
           
            return View(model);
        }
        public IActionResult Edit(string id)
        {
            //TODO create logic
            return View();
        }
        public IActionResult Delete(string id)
        {
            //TODO create logic
            return View();
        }
    }
}
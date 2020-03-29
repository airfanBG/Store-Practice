using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Store.Data.Common.Automapper;
using Store.Data.Common.Repositories;
using Store.Data.Common.Services;
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
        [Authorize(Roles ="Seller, Warehouse")]
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
                    string id = res.Id;
                    model.Id = id;
                    return Json(JsonConvert.SerializeObject(model));
                }
                return View("Index");
            }
           
            return View(model);
        }
        [HttpPut]
        [Authorize(Roles = "Seller, Warehouse")]
        public IActionResult Edit(ProductViewModel model)
        {
            bool isAjaxCall = Request.Headers["x-requested-with"] == "XMLHttpRequest";
            if (ModelState.IsValid)
            {
                var res = MapperConfigurator.Mapper.Map<Product>(model);
                this.Context.Products.Update(res);
                int status=this.Context.SaveChanges();
                if (status==1 && isAjaxCall)
                {
                    Response.StatusCode =(int) HttpStatusCode.OK;
                    return Json(JsonConvert.SerializeObject(model));
                }
                else
                {
                    if (isAjaxCall)
                    {
                        Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        return Json(JsonConvert.SerializeObject("Server error."));
                    }
                    return BadRequest();
                }
            }
            else
            {
                if (isAjaxCall)
                {
                    //Response.StatusCode = (int)HttpStatusCode.BadRequest;

                    var errors= JsonConvert.SerializeObject(ModelState.GetErrors());
                    
                    return Content(errors);
                }
                return View(model);
            }
         
        }
        public IActionResult Delete(string id)
        {
            //TODO create logic
            return View();
        }
    }
}
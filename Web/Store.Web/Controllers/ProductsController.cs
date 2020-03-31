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
using X.PagedList;

namespace Store.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IStoreContextData Context { get; }
        private int pageSize = 10;
        public ProductsController(IStoreContextData db)
        {
            Context = db;
        }
        public IActionResult Index(int? page)
        {
            //Automapper library
            
            var res=MapperConfigurator.Mapper.Map<List<ProductViewModel>>(Context.Products.All());
        
            return View(res.ToPagedList(page ?? 1,pageSize));
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
                if (status==1)
                {
                    if (isAjaxCall)
                    {
                        Response.StatusCode = (int)HttpStatusCode.OK;
                        return Json(JsonConvert.SerializeObject(model));
                    }
                    return View();
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
            var item = this.Context.Products.All(x => x.Id == id).SingleOrDefault();
            bool isAjaxCall = Request.Headers["x-requested-with"] == "XMLHttpRequest";
            this.Context.Products.Delete(item);
            var res=this.Context.SaveChanges();
            if (res==1)
            {
                if (isAjaxCall)
                {
                   
                    return Json(Response.StatusCode = (int)HttpStatusCode.OK);
                }
                return View();
            }
            else
            {
                if (isAjaxCall)
                {
                    return Json(Response.StatusCode = (int)HttpStatusCode.BadRequest);
                }
            }
            return StatusCode(400);
        }
    }
}
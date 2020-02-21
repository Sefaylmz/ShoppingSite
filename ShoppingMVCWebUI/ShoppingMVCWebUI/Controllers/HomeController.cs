using ShoppingMVCWebUI.Entity;
using ShoppingMVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingMVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var products = db.Products.Where(i =>i.IsHome && i.IsApproved)
                .Select(i=> new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length>50? i.Description.Substring(0,47)+"..." :  i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    categoryId = i.categoryId
                }).ToList();


            return View(products);
        }
        public ActionResult Details(int id)
        {
            var products = db.Products.Where(i => i.Id ==id).FirstOrDefault();
            return View(products);
        }
        public ActionResult List(int? id)
        {
            if (id!=null)
            {
               var products = db.Products.Where(i => i.categoryId == id && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    categoryId = i.categoryId
                }).ToList();
                return View(products);
            }
            else
            {
               var products = db.Products.Where(i =>i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    categoryId = i.categoryId
                }).ToList();
                return View(products);
            }
            
           
        }
        public PartialViewResult GetCategories()
        {
            var products = db.Categories.ToList();
            return PartialView(products);
        }
    }
}
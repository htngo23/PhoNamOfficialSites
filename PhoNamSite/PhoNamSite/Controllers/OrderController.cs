using PhoNamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoNamSite.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _dbContext;

        public OrderController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {

            var menuProduct = _dbContext.MenuProducts.ToList();


            return View(menuProduct);
            //return View();
        }
        public ActionResult Browse(string product)
        {            
            var ProductModel = _dbContext.MenuProducts.SingleOrDefault(g => g.MenuID == product);

            return View(ProductModel);
        }
        
    }
}
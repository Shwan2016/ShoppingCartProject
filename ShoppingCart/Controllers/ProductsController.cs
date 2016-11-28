using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Products
        
        public ActionResult Index()
        {
            var products = _context.Products.Include(p => p.Manufacturer).ToList();
            return View(products); 
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.Include(p => p.Manufacturer).SingleOrDefault(p => p.Id == id);
            return View(product);
        }
       
    }
}
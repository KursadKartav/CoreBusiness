using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService; //ProductManageri buraya eklememiz gerekiyor o yüzden bunu yaptık.Burdan iletişim kurduk.Sonra startupta düzenledik.
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page=1 , int category=0) //categorye göre listelesin diye
        {
            int pageSize = 10; //sayfada 10 tane ürün olsun.
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(), //tag helperlarım sayfalama yapabilmek için.
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };
            return View(model);
        }
        //public string Session()
        //{
        //    HttpContext.Session.SetString("City", "Ankara"); //Veriyi tutma
        //    HttpContext.Session.SetInt32("Age", 24);

        //    HttpContext.Session.GetString("City"); //Veriyi okuma
        //    HttpContext.Session.GetInt32("Age");
        //}
    }
}

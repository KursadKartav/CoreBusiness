using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.Web.Models;
using Abc.Northwind.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.Web.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService; //ihtiyacım olan servisler
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService) //Dependency Injection
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public ActionResult AddToCart(int productId) //Sepete ekleme
        {
            var productToBeAdded = _productService.GetById(productId);//ürünün son halini veritabanından çekmek için.                       

            var cart = _cartSessionService.GetCart(); //

            _cartService.AddToCart(cart,productToBeAdded);//producttobeadded a ürün ekle

            _cartSessionService.SetCart(cart);//veritabanına nesnemi ekle

            TempData.Add("message", String.Format("Your product, {0},was succesfully added to the cart",productToBeAdded.ProductName));//tempdata sadece tek bir requestlik değer taşır.Bir mesaj vermek istiyorsam kullanılırım.

            return RedirectToAction("Index", "Product"); //tekrar buraya dönder.
        }
        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }
        public ActionResult Remove(int productId)//model binding için parametre veriyoruz.
        {
            var cart = _cartSessionService.GetCart();//önce sessionu çektik
            _cartService.RemoveFromCart(cart, productId);//sessiondaki productid olanı sildik.
            _cartSessionService.SetCart(cart);//cart bilgisini tekrardan sessiona yazdık.
            TempData.Add("message", String.Format("Your product was successfully removed from the cart"));
            return RedirectToAction("List");
        }
        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel();
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0},your order is in process", shippingDetails.FirstName));
            return View();
        }
    }
}
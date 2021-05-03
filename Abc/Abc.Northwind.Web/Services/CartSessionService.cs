using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.Web.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.Services
{
    public class CartSessionService : ICartSessionService //Concretesini de aynı dosya içinde oluşturduk (Services)
    {
        private IHttpContextAccessor _httpContextAccessor; //httpcontext. dediğimde session gelmiyor çünkü sessiond controllerlarla kullanılır o yüzden controller olmayan yerde kullanmak için bu yöntemi uygularız. 
        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Cart GetCart()
        {
           Cart cartToCheck=  _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart"); //sepette varsa o ürünü döndür
            if (cartToCheck == null) //Yoksa oluştur.
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart"); 
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart); 
        }
    }
}

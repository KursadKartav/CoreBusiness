using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId); //sepette ürün var mı kontrol et
            if (cartLine != null) //sepette ürün varsa
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity=1 }); //ürün yoksa ekle
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId)); 
        }
    }
}

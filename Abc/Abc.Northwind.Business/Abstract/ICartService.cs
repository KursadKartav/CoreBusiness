using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICartService 
    {
        void AddToCart(Cart cart, Product product);//sepete ekleme
        void RemoveFromCart(Cart cart, int productId);//sepetteki ürünü silme
        List<CartLine> List(Cart cart);//listelemek için
    }
}

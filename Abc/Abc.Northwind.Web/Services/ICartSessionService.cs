using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.Services
{
    public interface ICartSessionService
    {
        Cart GetCart(); //Sessiondaki cart nesnesini getir (oku)
        void SetCart(Cart cart); //Sessiona yaz
    }
}

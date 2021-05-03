using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Cart //sepetin kendisi
    {
        public Cart() 
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; } //sepetin elemanları olur sepette

        public decimal Total //ücret
        {
            get { return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class CartLine //Sepet elemanları
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

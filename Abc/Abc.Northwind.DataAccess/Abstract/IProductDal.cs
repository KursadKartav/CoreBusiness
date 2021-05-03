using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> //IEntityRepositorynin içindeki her şey producta uygulanmış gibi düşünebiliriz.
    {
        //Custom Operations
    }
}

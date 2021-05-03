using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productdal) //Ben ProductManageri newlediğimde bana bir productdal ver demek.
        {
            _productDal = productdal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId=productId});
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList(); //getliste ulaşmak için yukarda dependency injection yaptım yani _pro=pro işlemi.
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId==0);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId); //benim gönderdiğim product id yi döndür
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

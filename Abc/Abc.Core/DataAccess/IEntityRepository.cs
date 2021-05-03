using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class , IEntity,new() //Generic olacak o yüzden T.
    {
        T Get(Expression<Func<T,bool>> filter=null); //Get=Bir id ye karşılık gelen müşterinin bilgileri yani tek bir nesne çekmek için bunu kullanırız.(Parametre ile)
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}

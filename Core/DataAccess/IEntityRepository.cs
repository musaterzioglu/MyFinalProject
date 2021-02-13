using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    
    //generic constraint - generic kısıt
    //class : referans tip
    //where T:class,IEntity demek, T bir referans tip olmalı ve T ya IEntity olabilir
    //ya da IEntity'den implemente olan bir nesne olabilir.
    //new() : new'lenebilir olmalı - IEntity(interface) soyut bir nesne, new'lenemez
    //ve bununla birlikte sistemimiz gerçekten veritabani nesneleri ile çalışan bir hale geldi. (DataAccess.Abstract bk.)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

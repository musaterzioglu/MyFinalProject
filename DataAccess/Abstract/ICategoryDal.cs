using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //ICategoryDal:IEntityRepository<> içine herhangi bir class yazabiliyorduk.
    //Filtreledikten sonra herhangi bir class yazamaz hale getiriyoruz. T'yi referans tiple sınırladık.  public interface IEntityRepository<T> where T:class
    //T ya IEntity olabilir ya da onu implemente eden bir nesne olabilir.                                public interface IEntityRepository<T> where T:class,IEntity
    //ICategoryDal:IEntityRepository<> IEntity new'lenemeyeceği için artık buraya IEntity koyamayız.     public interface IEntityRepository<T> where T:class,IEntity,new()
    //IEntity soyut bir nesne olmamalı ve parametresiz bir constructor'ı olmalı çünkü new'lenemiyor.
    //Sistemimiz gerçekten veritabani nesneleri ile çalışan bir repository oldu
    //ICategoryDal:IEntityRepository<> içine Category yazdığımızda kızmaz.
    //çünkü iki kuralı da karşılıyor. Hem referans tip hem de IEntity
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    public interface ICategoryDal:IEntityRepository<Category>
    {
       
    }
}

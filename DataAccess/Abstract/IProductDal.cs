using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface'in operasyonları default public'tir, kendisi değil
    //Arkadaşım IProductDal sen bir IEntityRepository'sin 
    //ve çalışma tipin Product'tır.
    public interface IProductDal : IEntityRepository<Product>
    {
        

    }
}

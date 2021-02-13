using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface'in operasyonları default public'tir, kendisi değil
    //Arkadaşım IProductDal sen bir IEntityRepository'sin 
    //ve çalışma tipin Product'tır.
    //Buraya ürüne ait özel operasyonları koyucaz.
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

    //Code Refactoring

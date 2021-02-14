using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //IResult yerine IDataResult yazıyoruz. 
        //İşlem sonucunu ve mesajı içeren ve döndüreceği List of Product List<Product> içeren bir yapı görevi görecek
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //Tek başına bir ürün döndürüyor. 

        IResult Add(Product product); //IResult döndür, void döndürmek yerine.
       
    }
}

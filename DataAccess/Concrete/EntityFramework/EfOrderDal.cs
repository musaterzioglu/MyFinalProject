using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Şu an bu 3 tane class'ı ekleyerek, sen Order'ler için tek tabloyu ilgilendiren bütün sql operasyonların hazır bunu kullanabilirsin.
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}

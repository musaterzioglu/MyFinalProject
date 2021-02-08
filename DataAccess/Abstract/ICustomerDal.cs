using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //ICustomerDal'a dedim ki sen bir Customer repository'sisin
    public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(); //Tümünü listeler.
        Category GetById(int categoryId); //Ben sana categoryId vereyim sen bana ilgili category'i ver.
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Veri erişimde EntityFramework, Nhibernate, Dapper gibi araçlar için kullanmaya dönebiliriz.
        //Bağlılığımızı minimize ediyoruz. Bağımlılığımı constructor injection ile yapıyorum.

        ICategoryDal _categoryDal;
        //Genarate constructor
        //bu şu demek ben CategoryManager olarak veri erişim katmanına bağlıyım ama biraz zayıf bağlılığım var
        //interface, referans üzerinden bağımlıyım.
        //O yüzden sen DataAccess katmanında istediğin kadar at koşturabilirsin, yeter ki kurallarıma uy
        
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}

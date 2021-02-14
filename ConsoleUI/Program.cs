using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //Open Closed Princible
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryManager bir ICategoryDal istiyor. 
            //Bende hatırlıyorum. Bunun için bir soyutlama yapmıştık. new EFCategoryDal() ekliyoruz.
            //Ekleme silme güncelleme listeleme tek tablo için olan her şey şu an hazır..
            //IoC container
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}

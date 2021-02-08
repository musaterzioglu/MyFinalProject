using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //siz bir class'ı new'lediğinizde o bellekten garbagecollector belli bir zamanda düzenli olarak gelir ve o bellekten onu atar.
            //using içine yazdığınız nesneler using bitince anında garbagecollector'a geliyor ve beni bellekten at diyor.
            //yani NorthwindContext bellekten işi bitince atılacak.
            //new'lesen de olur ama bu hareketle daha performanslı bir ürün elde etmiş oluruz.
            //IDisposable pattern implementation of c#, bu using yukardaki ile aynı değil araştır!

            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //git veri kaynağımdan benim bu gönderdiğim product'a bir tane nesneyi eşleştir.(referansı yakalama)
                addedEntity.State = EntityState.Added; //o aslında eklenecek bir nesne
                context.SaveChanges(); //Ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges(); 
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }
        //return filter == null ? context.Set<Product>().ToList() 
        //veritabanındaki bütün tabloyu listeye çevir bana ver. 
        //Bu aslında bizim için Select*From Product' ı arka planda çalıştırıyor.
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

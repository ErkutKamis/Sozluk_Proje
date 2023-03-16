using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public  class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context(); // Context sınıfından bir nesne türetiyoruz.
        DbSet<T> _object; // T değerine karşılık gelen sınıfı tutuyor. 

        public GenericRepository()
        {
            _object = c.Set<T>(); // _object isimli field' ımız dışarıdan gönderdiğimiz entity ne ise o olması için
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            // _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); // Bir dizide veya listede sadece 1 değer döndürmek için kullanılan Linq komutu
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            // _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); // Burada şartımız şu , filter ' dan gelen değere göre bana listeleme yap.
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges(); 
        }
    }
}

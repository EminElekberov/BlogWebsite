using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new MyContext();
            c.Remove(t);
            c.SaveChangesAsync();
        }

        public List<T> GetAllList()
        {
            using var c = new MyContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            using var c = new MyContext();
            return c.Set<T>().Where(filter).ToList();
        }
        public T GetById(int id)
        {
            using var c = new MyContext();
            return c.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            MyContext myContext = new MyContext();
            myContext.Add(t);
            myContext.SaveChanges();
        }

        public void Update(T t)
        {
            using var myContext = new MyContext();
            myContext.Update(t);
            myContext.SaveChanges();
        }
    }
}

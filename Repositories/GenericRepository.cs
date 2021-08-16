using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T par)
        {
            c.Set<T>().Add(par);
            c.SaveChanges();
        }

        public void TDelete(T par)
        {
            c.Set<T>().Remove(par);
            c.SaveChanges();
        }
        public void TUpdate(T par)
        {
            c.Set<T>().Update(par);
            c.SaveChanges();
        }
        public T TGet(int id)
        {
           return c.Set<T>().Find(id);
        }

        public List<T> TList(string par)
        {
            return c.Set<T>().Include(par).ToList();
        }

        public List<T> List(Expression<Func<T,bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

    }
}

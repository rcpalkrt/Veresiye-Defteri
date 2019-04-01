using BAKKAL_DAL.Contexts;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BLL.SqlRepostories
{
    public class SqlRepository<T> where T : class
    {
        SQLDbContext db = new SQLDbContext();
        public IQueryable<T> Listele()
        {
            return db.Set<T>();
        }
        public IQueryable<T> Listele(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression);
        }
        public void Insert(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void Insert(ICollection<T> entities)
        {
            db.Set<T>().AddRange(entities);
            db.SaveChanges();
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
        public void Delete(ICollection<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

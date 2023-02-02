using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DataAccessContext _context = new DataAccessContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object=_context.Set<T>();
        }
        public void Add(T p)
        {
            _object.Add(p);
            _context.SaveChanges();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            _context.SaveChanges();
        }

        public List<T> Get(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            _context.SaveChanges();
        }
    }
}

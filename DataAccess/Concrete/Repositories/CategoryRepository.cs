using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        DataAccessContext _context=new DataAccessContext();
        DbSet<Category> _object;
        public void Add(Category category)
        {
            _object.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _object.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();
        }

        public void Update(Category category)
        {
            _context.SaveChanges();
        }
    }
}

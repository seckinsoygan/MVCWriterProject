using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        List<T> GetAll();
        List<T> Get(Expression<Func<T, bool>> filter);
        void Add(T p);
        void Update(T p);
        void Delete(T p);
    }
}

using DataAccess.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.GetAll();
        }
        public void Add(Category category)
        {
            if(category.CategoryName =="" || category.CategoryName.Length <= 3)
            {
                
            }
            repo.Add(category);
        }
    }
}

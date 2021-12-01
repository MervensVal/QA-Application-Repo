using QA_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Category> viewAllCategories()
        {
            return _db.Category.ToList();
        }

        public void addCategory(Category c)
        {
            _db.Category.Add(c);
            _db.SaveChanges();
        }

        public void archive(Category c)
        {

        }

        public Category getCategoryById(int id)
        {
            throw new NotImplementedException();
        }

    }
}

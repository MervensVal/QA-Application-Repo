using QA_Application.Data;
using QA_Application.ViewModels;
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
            _db.Category.Update(c);
            _db.SaveChanges();
        }

        public Category getCategoryById(int id)
        {
            return _db.Category.FirstOrDefault(c => c.CategoryId == id);
        }

    }
}

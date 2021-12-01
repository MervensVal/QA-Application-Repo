using QA_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Application.Models
{
   public interface ICategoryRepository
    {
        public IEnumerable<Category> viewAllCategories();
        public void addCategory(Category c);
        public Category getCategoryById(int id);
        public void archive(Category c); 
    }
}


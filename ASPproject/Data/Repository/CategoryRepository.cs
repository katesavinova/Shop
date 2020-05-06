using ASPproject.Data.Models;
using ASPproject.Data.Models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}

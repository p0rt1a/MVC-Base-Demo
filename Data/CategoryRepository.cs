using ShopAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppDemo.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        public static List<Category> Categories { get { return _categories; } }
        static CategoryRepository()
        {
            _categories = new List<Category>() {
                new Category() { Id = 1, Name = "Chinese" },
                new Category() { Id = 2, Name = "Fast" },
                new Category() { Id = 3, Name = "Italian" },
            };
        }
    }
}

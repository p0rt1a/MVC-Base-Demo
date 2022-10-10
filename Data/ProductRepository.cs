using Microsoft.AspNetCore.Http;
using ShopAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppDemo.Data
{
    public class ProductRepository
    {
        private static List<Product> _products = null;
        public static List<Product> Products { get { return _products; } }

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Food 1", Description="Lorem ipsum dolor sit amet.", ImageUrl = "chinese-food-1.jpg", CategoryId = 1 },
                new Product() { Id = 2, Name = "Food 2", Description="Lorem ipsum dolor sit amet.", ImageUrl = "chinese-food-2.jpg", CategoryId = 1 },
                new Product() { Id = 3, Name = "Food 3", Description="Lorem ipsum dolor sit amet.", ImageUrl = "chinese-food-3.jpg", CategoryId = 1 },
                new Product() { Id = 4, Name = "Food 4", Description="Lorem ipsum dolor sit amet.", ImageUrl = "chinese-food-4.jpg", CategoryId = 1 },
                new Product() { Id = 5, Name = "Food 1", Description="Lorem ipsum dolor sit amet.", ImageUrl = "fast-food-1.jpg", CategoryId = 2 },
                new Product() { Id = 6, Name = "Food 2", Description="Lorem ipsum dolor sit amet.", ImageUrl = "fast-food-2.jpg", CategoryId = 2 },
            };
        }


        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public static List<Product> GetProductByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}

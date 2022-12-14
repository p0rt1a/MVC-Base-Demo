using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopAppDemo.Data;
using ShopAppDemo.Models;
using ShopAppDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ProductViewModel viewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products,
                Categories = CategoryRepository.Categories
            };

            return View(viewModel);
        }


        [HttpPost]
        public IActionResult List(int Id)
        {
            ProductViewModel viewModel = new ProductViewModel()
            {
                Products = ProductRepository.GetProductByCategory(Id)
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            ProductRepository.DeleteProduct(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "Id", "Name");
            return View(ProductRepository.GetProductById(Id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return RedirectToAction("Index");
        }
    }
}

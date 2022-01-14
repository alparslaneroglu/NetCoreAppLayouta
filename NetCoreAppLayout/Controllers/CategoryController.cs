using Microsoft.AspNetCore.Mvc;
using NetCoreAppLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("create-category")] // Attribute routing yani sayfa buradaki rout açılsın.
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create-category-page")]
        public IActionResult Create([Bind("Name","Description")]CategoryCreateInputModel model)
        {
            if (ModelState.IsValid)
            {
                //Veri tabanına kaydı gönder.
            }
            return View();
        }

        [HttpGet("update-category")] // Attribute routing yani sayfa buradaki rout açılsın.
        public IActionResult Update()
        {
            var model = new CategoryUpdateInputModel
            {
                Name = "Deneme",
                Description = "Test"
            };
            return View(model);
        }
        [HttpPost("update-category-page")]
        public IActionResult Update([Bind("Name", "Description")] CategoryUpdateInputModel model)
        {
            if (ModelState.IsValid)
            {
                //Veri tabanına kaydı gönder.
            }
            return View();
        }
    }
}

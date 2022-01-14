using Microsoft.AspNetCore.Mvc;
using NetCoreAppLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SendComment([FromBody] CommentInputModel model)
        {
            return Json("OK");
        }
    }
}

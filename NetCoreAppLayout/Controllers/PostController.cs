using Microsoft.AspNetCore.Mvc;
using NetCoreAppLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Controllers
{
    public class PostController : Controller
    {
        [HttpGet("post-detail/{postId}")]
        public IActionResult Detail(string postId)
        {
            var post = new CommentManager().GetPostComment();
            if (post.Id != postId)
            {
                return NotFound();
            }
            var model = new PostDetailViewModel
            {
                PostBody = post.Description,
                PostId = post.Id,
                PostTitle = post.Title,
                PostComments = post.Comments.Select(a => new CommentViewModel
                {
                    CommentBy = a.CommentsUser.UserName,
                    CommentDate = a.Date,
                    Message = a.Body

                }).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public JsonResult SendComment([FromBody] CommentInputModel model)
        {
            return Json("OK");
        }
    }
}

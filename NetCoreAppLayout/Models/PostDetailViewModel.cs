using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }

    }
    public class Comment
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; } // Kim attı
        public string PostId { get; set; }
        public DateTime Date { get; set; } // yorum tarih
        public User CommentsUser { get; set; }
        public Post CommentPost { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

    }
    public class CommentManager
    {
        public Post GetPostComment()
        {

            var post = new Post
            {
                Id = Guid.NewGuid().ToString(),
                Comments = new List<Comment>(),
                Description = "Makale-1",
                Title = "Makale"
            };
            var user1 = new User
            {
                Email = "test@test.com",
                Id = Guid.NewGuid().ToString(),
                UserName = "test-user"
            };
            var user2 = new User
            {
                Email = "test2@test.com",
                Id = Guid.NewGuid().ToString(),
                UserName = "test-user2"
            };
            post.Comments.Add(new Comment
            {
                Body = "Comment-1",
                CommentsUser = user1,
                CommentPost = post,
                Date = DateTime.Now.AddDays(-2),
                Id = Guid.NewGuid().ToString(),
                PostId = post.Id,
                UserId = user1.Id
            }); 
            
            post.Comments.Add(new Comment
            {
                Body = "Comment-2",
                CommentsUser = user2,
                CommentPost = post,
                Date = DateTime.Now.AddDays(-3),
                Id = Guid.NewGuid().ToString(),
                PostId = post.Id,
                UserId = user2.Id
            });
            return post;
        }
    }



    public class PostDetailViewModel
    {
        public string PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public List<CommentViewModel> PostComments { get; set; }
    }
    public class CommentViewModel
    {
        public string CommentBy { get; set; }
        public string Message { get; set; }
        public DateTime CommentDate { get; set; }

    }
}

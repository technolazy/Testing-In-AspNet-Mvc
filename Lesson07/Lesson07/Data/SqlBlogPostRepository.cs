using Lesson07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson07.Data
{
    public class SqlBlogPostRepository : IBlogPostRepository
    {
        private readonly static List<BlogPost> _blogPosts;

        static SqlBlogPostRepository()
        {
            _blogPosts = new List<BlogPost>();

            _blogPosts.Add(new BlogPost
            {
                Id = 1,
                Title = "First Blog Post",
                Content = "This is the first blog post!",
                DateCreated = DateTime.Now.AddDays(-4)
            });

            _blogPosts.Add(new BlogPost
            {
                Id = 2,
                Title = "Second Blog Post",
                Content = "This is the second blog post!",
                DateCreated = DateTime.Now.AddDays(-3)
            });

            _blogPosts.Add(new BlogPost
            {
                Id = 3,
                Title = "Third Blog Post",
                Content = "This is the third blog post!",
                DateCreated = DateTime.Now.AddDays(-2)
            });

            _blogPosts.Add(new BlogPost
            {
                Id = 4,
                Title = "Fourth Blog Post",
                Content = "This is the fourth blog post!",
                DateCreated = DateTime.Now.AddDays(-1)
            });
        }

        public BlogPost GetById(int id)
        {
            return _blogPosts.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<BlogPost> All()
        {
            return _blogPosts.ToArray();
        }

        public void Edit(BlogPost post)
        {
            var oldPost = GetById(post.Id);

            if (oldPost == null)
            {
                return;
            }

            oldPost.Title = post.Title;
            oldPost.Content = post.Content;
        }

        public void Delete(BlogPost post)
        {
            var toDelete = GetById(post.Id);

            if (toDelete != null)
            {
                _blogPosts.Remove(toDelete);
            }
        }
    }
}
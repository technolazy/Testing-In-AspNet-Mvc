using Lesson07.Models;
using System;
using System.Collections.Generic;
namespace Lesson07.Data
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> All();
        void Delete(BlogPost post);
        void Edit(BlogPost post);
        BlogPost GetById(int id);
    }
}

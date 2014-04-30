using Lesson06.Models;
using System;
using System.Collections.Generic;
namespace Lesson06
{
    public interface IBlogPostRepository
    {
        IEnumerable<Lesson06.Models.BlogPost> All();
        void Delete(Lesson06.Models.BlogPost post);
        void Edit(Lesson06.Models.BlogPost post);
        BlogPost GetById(int id);
    }
}

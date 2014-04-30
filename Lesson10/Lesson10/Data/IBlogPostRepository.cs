using Lesson10.Models;
using System;
using System.Collections.Generic;
namespace Lesson10.Data
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> All();
        void Delete(BlogPost post);
        void Edit(BlogPost post);
        BlogPost GetById(int id);
        IEnumerable<BlogPost> FindByDate(int year);
        IEnumerable<BlogPost> FindByDate(int year, int month);
        IEnumerable<BlogPost> FindByDate(int year, int month, int day);


    }
}

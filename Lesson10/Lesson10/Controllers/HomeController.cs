using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson10.Models;
using Lesson10.Data;

namespace Lesson10.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogPostRepository _repository;
        public HomeController() :
            this(new SqlBlogPostRepository())
        {

        }

        public HomeController(IBlogPostRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /Home/
        public ActionResult Index(int year = 0, int month = 0, int day = 0, int id = 0)
        {
            if (year == 0)
            {
                return View(_repository.All());
            }

            if (id > 0)
            {
                var posts = _repository.FindByDate(year, month, day);

                return View(posts.Where(p => p.Id == id));
            }

            if (day > 0)
            {
                return View(_repository.FindByDate(year, month, day));
            }

            if (month > 0)
            {
                return View(_repository.FindByDate(year, month));
            }

            return View(_repository.FindByDate(year));
        }
	}
}
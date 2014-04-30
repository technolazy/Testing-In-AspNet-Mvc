using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson07.Models;
using Lesson07.Data;

namespace Lesson07.Controllers
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
        public ActionResult Index()
        {
            var model = _repository.All();
            return View(model);
        }
	}
}
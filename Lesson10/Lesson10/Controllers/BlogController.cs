using Lesson10.Data;
using Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson10.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogPostRepository _repo;

        public BlogController() :
            this(new SqlBlogPostRepository()) { }

        public BlogController(IBlogPostRepository repository)
        {
            _repo = repository;
        }

        //
        // GET: /Blog/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var post = _repo.GetById(id);

            if (post == null)
            {
                return new HttpNotFoundResult();
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(BlogPost model)
        {
            if (ModelState.IsValid)
            {
                _repo.Edit(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson05.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(int count = 10)
        {
            var fizzBuzz = new FizzBuzz();
            var model = fizzBuzz.Generate(count);

            return View(model);
        }
	}
}
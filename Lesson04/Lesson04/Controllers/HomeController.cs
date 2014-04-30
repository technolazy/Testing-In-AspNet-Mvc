using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public string Index(int count = 10)
        {
            var fizzBuzz = new FizzBuzz();
            var values = fizzBuzz.Generate(count).ToArray();
 
            return string.Join(" ", values);
        }
	}
}
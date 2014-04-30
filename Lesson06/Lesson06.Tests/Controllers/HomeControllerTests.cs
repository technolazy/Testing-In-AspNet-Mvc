using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections.Generic;
using Lesson06.Models;
using System.Linq;
using Lesson06.Controllers;

namespace Lesson06.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexDisplaysAllPosts()
        {
            var repo = new TestBlogPostRepository();
            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index();
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(4, model.Count());
        }
    }
}

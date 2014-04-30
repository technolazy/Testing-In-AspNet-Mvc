using Lesson10.Controllers;
using Lesson10.Data;
using Lesson10.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.JustMock;

namespace Lesson10.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexDisplaysAllPosts()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            Mock.Arrange(() => repo.All()).Returns(
                new[] { 
                    new BlogPost(),
                    new BlogPost(),
                    new BlogPost(),
                    new BlogPost()
            });

            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index();
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(4, model.Count());
        }

        [TestMethod]
        public void IndexDisplaysPostsFromYear()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            Mock.Arrange(() => repo.FindByDate(2014)).Returns(
                new[] { 
                    new BlogPost(),
                    new BlogPost(),
                    new BlogPost()
            });

            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index(2014);
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(3, model.Count());
        }

        [TestMethod]
        public void IndexDisplaysPostsFromMonth()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            Mock.Arrange(() => repo.FindByDate(2013, 6)).Returns(
                new[] { 
                    new BlogPost(),
                    new BlogPost()
            });

            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index(2013, 6);
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(2, model.Count());
        }

        [TestMethod]
        public void IndexDisplaysPostsFromDay()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            Mock.Arrange(() => repo.FindByDate(2013, 6, 9)).Returns(
                new[] { 
                    new BlogPost()
            });

            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index(2013, 6, 9);
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(1, model.Count());
        }

        [TestMethod]
        public void IndexDisplaysPostsWithDateAndId()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            Mock.Arrange(() => repo.FindByDate(2013, 6, 9)).Returns(
                new[] { 
                    new BlogPost { Id = 1},
                    new BlogPost { Id = 4},
                    new BlogPost { Id = 145}


            });

            var controller = new HomeController(repo);

            var result = (ViewResult)controller.Index(2013, 6, 9, 145);
            var model = (IEnumerable<BlogPost>)result.Model;

            Assert.AreEqual(1, model.Count());
        }
    }
}

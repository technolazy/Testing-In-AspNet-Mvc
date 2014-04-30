using Lesson07.Controllers;
using Lesson07.Data;
using Lesson07.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.JustMock;

namespace Lesson07.Tests.Controllers
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
    }
}

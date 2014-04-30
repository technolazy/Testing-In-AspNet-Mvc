using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Lesson09.Data;
using Lesson09.Controllers;
using Lesson09.Models;
using System.Web.Mvc;

namespace Lesson09.Tests.Controllers
{
    [TestClass]
    public class BlogControllerTest
    {
        [TestMethod]
        public void Edit_Get_SendsModelToView()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            var controller = new BlogController(repo);

            Mock.Arrange(() => repo.GetById(1))
                .Returns(new BlogPost { Id = 1 });

            var result = (ViewResult)controller.Edit(1);
            var model = (BlogPost)result.Model;

            Assert.AreEqual(1, model.Id);
        }

        [TestMethod]
        public void Edit_Get_Returns404ForNonexistentBlogPost()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            var controller = new BlogController(repo);

            Mock.Arrange(() => repo.GetById(1))
                .Returns(() => null);

            var result = controller.Edit(1);

            Assert.IsTrue(result is HttpNotFoundResult);
        }

        [TestMethod]
        public void Edit_Post_EditOnRepositoryIsCalled()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            var controller = new BlogController(repo);

            Mock.Arrange(() => repo.Edit(Arg.IsAny<BlogPost>()))
                .MustBeCalled();

            var post = new BlogPost
            {
                Id = 1,
                Title = "",
                Content = "",
                DateCreated = DateTime.Now
            };

            var result = controller.Edit(post);

            Mock.Assert(repo);

            Assert.IsTrue(result is RedirectToRouteResult);
        }

        [TestMethod]
        public void Edit_Post_ReturnsViewWithModelWhenModelStateIsInvalid()
        {
            var repo = Mock.Create<IBlogPostRepository>();
            var controller = new BlogController(repo);

            var post = new BlogPost
            {
                Id = 1,
                Title = "",
                Content = "",
                DateCreated = DateTime.Now
            };

            controller.ViewData.ModelState.AddModelError("key", "error message");

            var result = (ViewResult)controller.Edit(post);

            Assert.AreEqual(post, result.Model as BlogPost);
        }
    }
}

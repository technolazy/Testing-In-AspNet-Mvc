using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Routing;
using MvcRouteTester;

namespace Lesson10.Tests.Routing
{
    [TestClass]
    public class BlogTests
    {
        [TestMethod]
        public void BlogEditRoutesToBlogEdit()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Blog", action = "edit", id = 123 };

            RouteAssert.HasRoute(routes, "/blog/edit/123", route);
        }
    }
}

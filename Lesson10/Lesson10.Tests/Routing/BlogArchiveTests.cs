using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRouteTester;
using System.Web.Routing;

namespace Lesson10.Tests.Routing
{
    [TestClass]
    public class BlogArchiveTests
    {
        [TestMethod]
        public void RootUrlIsRoutedToHomeAndIndex()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Home", action = "index" };

            RouteAssert.HasRoute(routes, "/", route);
        }

        [TestMethod]
        public void YearUrlIsRoutedToHomeAndIndex()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Home", action = "index", year = 2014 };

            RouteAssert.HasRoute(routes, "/2014", route);
        }

        [TestMethod]
        public void MonthUrlIsRoutedToHomeAndIndex()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Home", action = "index", year = 2014, month = "02"};

            RouteAssert.HasRoute(routes, "/2014/02", route);
        }

        [TestMethod]
        public void DayUrlIsRoutedToHomeAndIndex()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Home", action = "index" };

            RouteAssert.HasRoute(routes, "/2014/02/01", route);
        }

        [TestMethod]
        public void IdUrlIsRoutedToHomeAndIndex()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            var route = new { controller = "Home", action = "index" };

            RouteAssert.HasRoute(routes, "/2014/02/01/216", route);
        }
    }
}

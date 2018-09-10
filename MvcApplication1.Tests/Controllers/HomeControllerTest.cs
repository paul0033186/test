using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Controllers;

namespace MvcApplication1.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 排列
            HomeController controller = new HomeController();

            // 作用
            ViewResult result = controller.Index() as ViewResult;

            // 判斷提示
            ViewDataDictionary viewData = result.ViewData;
            Assert.AreEqual("歡迎使用 ASP.NET MVC!", viewData["Message"]);
        }

        [TestMethod]
        public void About()
        {
            // 排列
            HomeController controller = new HomeController();

            // 作用
            ViewResult result = controller.About() as ViewResult;

            // 判斷提示
            Assert.IsNotNull(result);
        }
    }
}

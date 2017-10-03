using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationPractice;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_Main_Page()
        {
            MainPage.GoTo("http://automationpractice.com/");
            Assert.IsTrue(MainPage.Loaded());
        }
    }
}

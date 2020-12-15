using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsAppPJRubin;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod()]
        public void ConstructorPassesInAuthorCorrectly()
        {
            //Arrange
            Author a = new Author("Tom", "Gibbons");

            //Act

            //Assert
        }

        [TestMethod()]
        public void BookTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BookTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BookTest3()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}
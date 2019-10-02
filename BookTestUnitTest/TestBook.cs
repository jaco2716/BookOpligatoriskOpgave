using System;
using BookUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTestUnitTest
{
    [TestClass]
    public class TestBook
    {
        private Book book;

        [TestInitialize]
        public void TestInitialize()
        {
            book = new Book("Harry Potter", "JKR", 800, "3929384930275");
        }

        [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Harry Potter", book.Title);
            book.Title = "Potter Harry";
            Assert.AreEqual("Potter Harry", book.Title);
        }

        [TestMethod]
        public void TestAuther()
        {
            Assert.AreEqual("JKR", book.Auther);
            book.Auther = "Not JKR";
            Assert.AreEqual("Not JKR", book.Auther);
        }

        [TestMethod]
        public void TestPageNo()
        {
            Assert.AreEqual(800, book.PageNo);
            book.PageNo = 560;
            Assert.AreEqual(560, book.PageNo);
        }

        [TestMethod]
        public void TestIsbn13()
        {
            Assert.AreEqual("3929384930275", book.Isbn13);
            book.Isbn13 = "9248237598237";
            Assert.AreEqual("9248237598237", book.Isbn13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleException()
        {
            book.Title = "k";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNoException()
        {
            book.PageNo = 1309;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNoException2()
        {
            book.PageNo = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbnException()
        {
            book.Isbn13 = "135-reg3";
        }
        


    }
}

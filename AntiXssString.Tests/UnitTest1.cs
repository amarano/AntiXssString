using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AntiXssString.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Script_Tags_Should_Be_Removed()
        {
            var s = "<script>window.alert('hello, world')</script>";
            AntiXssString sut = s;
            string actual = sut;
            Assert.AreNotEqual(actual, s);
        }

        [TestMethod]
        public void Script_Tags_Should_Be_Removed_On_Concat()
        {
            AntiXssString sut = "<script>window.alert('hello, world')</script>";
            var newString = "" + sut;
            Assert.AreNotEqual("<script>window.alert('hello, world')</script>", newString);
        }

        [TestMethod]
        public void Script_Tags_Should_Be_Removed_On_Format()
        {
            AntiXssString sut = "<script>window.alert('hello, world')</script>";
            var newString = string.Format("{0}", sut);
            Assert.AreNotEqual("<script>window.alert('hello, world')</script>", newString);
        }
    }
}

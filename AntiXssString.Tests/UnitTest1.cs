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
    }
}

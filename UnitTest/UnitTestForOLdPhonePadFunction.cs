using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldPhonePadLibrary;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForOLdPhonePadFunction
    {
        [TestMethod]
        public void TestMethod_E()
        {
            string input = "4433555 555666#";
            string expected = "HELLO";
            string actual = OldPhonePadFunction.OldPhonePad(input);
            Assert.AreEqual(expected, actual);

        }
    }
}

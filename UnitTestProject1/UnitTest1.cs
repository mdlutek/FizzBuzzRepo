using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FizzBuzz fb = new FizzBuzz();

        string output = "";

        [TestMethod]
        public void TestMethod1()
        {
            output = fb.CheckNumber(5);

            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            output = fb.CheckNumber(3);

            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            output = fb.CheckNumber(15);

            Assert.AreEqual("Fizz Buzz", output);
        }

        [TestMethod]
        public void TestMethod4()
        {
            output = fb.CheckNumber(1);

            Assert.AreEqual(1, int.Parse(output));
        }
    }
}

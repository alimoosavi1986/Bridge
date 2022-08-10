using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BridgeTest
{
    [TestClass]
    public class ConcreateImplementorFixture
    {
        [TestMethod]
        public void ImplementaionTest()
        {
            Abstraction abstraction = new RefinedAbstraction();

            string expected = "Run   ConcreateImplementor.Implementaion()....";
            string actual = abstraction.Function();

            Assert.AreEqual(expected, actual);

        }
    }
}

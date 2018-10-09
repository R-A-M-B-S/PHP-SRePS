using NUnit.Framework;
using System;

namespace SalesApp.Tests
{
    [TestFixture()]
    public class SainityTest
    {
        [Test()]
		public void SimpleTest()
        {
			// A check to make sure something is working
			string text = "Hello" + ", World";

			Assert.AreEqual("Hello, World", text);
        }
    }
}

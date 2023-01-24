using ECert_Question_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestDuplicates
    {
        [TestMethod]
        public void TestDuplicate()
        {
            DuplicateHelper duplicateHelper = new DuplicateHelper();
            // find duplicates and show the index and value within the string
            var result = duplicateHelper.DuplicateFinder("rohhhhhhhit");
            Assert.AreEqual("position of h is 2 and value is hhhhhhh", result);
        }
    }
}

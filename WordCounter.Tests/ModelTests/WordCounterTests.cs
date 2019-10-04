using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{

    [TestClass]
    public class WordCounterTest
    {

        Counter counter;

        [TestInitialize]
        public void Startup()
        {
            counter = new Counter();
        }

        [TestCleanup]
        public void TestClean()
        {
            counter = null;
        }

        [TestMethod]
        public void CheckWord_AllowAnyCharInput_0()
        {
            // Arrange
            string sentence = "I ate 2 2# pies!";
            string search = "cat";
            // Act
            int count = counter.CheckWord(sentence, search);
            // Assert
            Assert.AreEqual(0,count);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{

    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void CheckWord_AllowAnyCharInput_0()
        {
            // Arrange
            string sentence = "I ate 2 2# pies!";
            string search = "cat";
            // Act
            int count = Counter.CheckWord(sentence, search);
            // Assert
            Assert.AreEqual(0,count);
        }

        [TestMethod]
        public void CheckWord_MatchExactWordInput_1()
        {
            // Arrange
            string sentence = "place";
            string search = "place";
            // Act
            int count = Counter.CheckWord(sentence, search);
            // Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CheckWord_NotExactWordInput_0()
        {
            // Arrange
            string sentence = "book";
            string search = "bookkeeper";
            // Act
            int count = Counter.CheckWord(sentence, search);
            // Assert
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CheckWord_MatchExactWordInputAndAllowDifferentCase_1()
        {
            // Arrange
            string sentence = "Place";
            string search = "place";
            // Act
            int count = Counter.CheckWord(sentence, search);
            // Assert
            Assert.AreEqual(1, count);
        }
    }
}
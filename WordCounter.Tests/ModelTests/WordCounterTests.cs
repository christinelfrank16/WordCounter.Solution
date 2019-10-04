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
            Counter counter = new Counter(sentence, search);
            // Act
            int count = counter.CheckWord();
            // Assert
            Assert.AreEqual(0,count);
        }

        [TestMethod]
        public void CheckWord_MatchExactWordInput_1()
        {
            // Arrange
            string sentence = "place";
            string search = "place";
            Counter counter = new Counter(sentence, search);
            // Act
            int count = counter.CheckWord();
            // Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CheckWord_NotExactWordInput_0()
        {
            // Arrange
            string sentence = "book";
            string search = "bookkeeper";
            Counter counter = new Counter(sentence, search);
            // Act
            int count = counter.CheckWord();
            // Assert
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CheckWord_MatchExactWordInputAndAllowDifferentCase_1()
        {
            // Arrange
            string sentence = "Place";
            string search = "place";
            Counter counter = new Counter(sentence, search);
            // Act
            int count = counter.CheckWord();
            // Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void IsOneWord_RestrictSearchTermToOneWord_True()
        {
            // Arrange
            string search = "place";
            string sentence = "no place like home";
            Counter counter = new Counter(sentence, search);
            // Act
            bool isOneWord = counter.IsOneWord();
            // Assert
            Assert.AreEqual(true, isOneWord);
        }

        [TestMethod]
        public void IsOneWord_RestrictSearchTermToOneWord_False()
        {
            // Arrange
            string search = "a place";
            string sentence = "no place like home";
            Counter counter = new Counter(sentence, search);
            // Act
            bool isOneWord = counter.IsOneWord();
            // Assert
            Assert.AreEqual(false, isOneWord);
        }

        [TestMethod]
        public void IsOneWord_RestrictSearchTermToOneWordWithTrim_True()
        {
            // Arrange
            string search = " place ";
            string sentence = "no place like home";
            Counter counter = new Counter(sentence, search);
            // Act
            bool isOneWord = counter.IsOneWord();
            // Assert
            Assert.AreEqual(true, isOneWord);
        }
    }
}
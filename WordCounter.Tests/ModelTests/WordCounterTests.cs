using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
        public void CheckForContent_MustHaveStringContent_True()
        {
            // Arrange
            string sentence = "I ate 2 2# pies!";
            string search = "cat";
            // Act
            bool sentenceContent = Counter.CheckForContent(sentence);
            bool searchContent = Counter.CheckForContent(search);
            // Assert
            Assert.AreEqual(true, sentenceContent);
            Assert.AreEqual(true, searchContent);
        }

        [TestMethod]
        public void CheckForContent_MustHaveStringContent_False()
        {
            // Arrange
            string value = "";
            // Act
            bool sentenceContent = Counter.CheckForContent(value);
            // Assert
            Assert.AreEqual(false, sentenceContent);
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

        [TestMethod]
        public void MakeSentenceList_MakeListWithSentenceWords_StringListOneWord()
        {
            // Arrange
            string search = "place";
            string sentence = "jumped";
            Counter counter = new Counter(sentence, search);
            List<string> expected = new List<string> {"jumped"};
            // Act
            List<string> sentenceList = counter.MakeSentenceList();
            // Assert
            CollectionAssert.AreEqual(expected, sentenceList);
        }

        [TestMethod]
        public void MakeSentenceList_MakeListWithSentenceWords_StringListMultipleWords()
        {
            // Arrange
            string search = "place";
            string sentence = "a cat jumped";
            Counter counter = new Counter(sentence, search);
            List<string> expected = new List<string> {"a", "cat", "jumped"};
            // Act
            List<string> sentenceList = counter.MakeSentenceList();
            // Assert
            CollectionAssert.AreEqual(expected, sentenceList);
        }

        [TestMethod]
        public void CountWordsInSentence_CountsExactWordMatchesInSentence_Int()
        {
            // Arrange
            string search = "cat";
            string sentence = "cat";
            Counter counter = new Counter(sentence, search);
            List<string> sentenceList = counter.MakeSentenceList();
            // Act
            int wordCount = counter.CountWordsInSentence(sentenceList);
            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void CountWordsInSentence_CountsExactWordMatchesInMultiWordSentence_Int()
        {
            // Arrange
            string search = "cat";
            string sentence = "a cat jumped";
            Counter counter = new Counter(sentence, search);
            List<string> sentenceList = counter.MakeSentenceList();
            // Act
            int wordCount = counter.CountWordsInSentence(sentenceList);
            // Assert
            Assert.AreEqual(1, wordCount);
        }


    }
}
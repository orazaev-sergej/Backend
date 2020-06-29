using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Translator;

namespace TranslatorTests
{
    [TestClass]
    public class TranslatorTests
    {
        Translator.Translator dictionary = new Translator.Translator("../../../../Translator/dictionary.txt");

        [TestMethod]
        public void InputRussianWord_TranslationIntoEnglishReturned()
        {
            string word = "привет";
            string expected = "hello";

            string result = dictionary.Translate(word);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InputEnglishWord_TranslationIntoRussianReturned()
        {
            string word = "hello";
            string expected = "привет";

            string result = dictionary.Translate(word);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void UnknownEnglishWord_NullReturned()
        {
            string word = "unknown";
            string expected = null;

            string result = dictionary.Translate(word);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void UnknownRussianWord_NullReturned()
        {
            string word = "неизвестное";
            string expected = null;

            string result = dictionary.Translate(word);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InputEmptyString_NullReturned()
        {
            string word = "";
            string result = dictionary.Translate(word);
            Assert.AreEqual(null, result);
        }
    }
}
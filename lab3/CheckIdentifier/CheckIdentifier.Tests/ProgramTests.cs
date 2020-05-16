using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckIdentifier.Tests
{
    [TestClass]
    public class CheckArgs
    {
        [TestMethod]
        public void input_oneArg_trueReturned()
        {
            string[] oneArg = new string[] { "argument" };
            bool expected = true;

            bool actual = Program.CheckArg(oneArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_twoArgs_falseReturned()
        {
            string[] twoArgs = new string[] { "first_argument", "second_argument" };
            bool expected = false;

            bool actual = Program.CheckArg(twoArgs);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_zeroArgs_falseReturned()
        {
            string[] zeroArgs = new string[] {  };
            bool expected = false;

            bool actual = Program.CheckArg(zeroArgs);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class IsEnglishLetter
    {
        [TestMethod]
        public void input_letter_A_returnedTrue()
        {
            char letter = 'A';
            bool expected = true;

            bool actual = Program.IsEnglishLetter(letter);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_letter_Z_returnedTrue()
        {
            char letter = 'Z';
            bool expected = true;

            bool actual = Program.IsEnglishLetter(letter);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_letter_a_returnedTrue()
        {
            char letter = 'a';
            bool expected = true;

            bool actual = Program.IsEnglishLetter(letter);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_letter_z_returnedTrue()
        {
            char letter = 'z';
            bool expected = true;

            bool actual = Program.IsEnglishLetter(letter);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_digit_0_returnedFalse()
        {
            char digit = '0';
            bool expected = false;

            bool actual = Program.IsEnglishLetter(digit);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_digit_9_returnedFalse()
        {
            char digit = '9';
            bool expected = false;

            bool actual = Program.IsEnglishLetter(digit);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_whitespace_returnedFalse()
        {
            char whitespace = ' ';
            bool expected = false;

            bool actual = Program.IsEnglishLetter(whitespace);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class isDigit
    {
        [TestMethod]
        public void input_0_trueReturned()
        {
            char zero = '0';
            bool expected = true;

            bool actual = Program.IsDigit(zero);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_5_trueReturned()
        {
            char five = '5';
            bool expected = true;

            bool actual = Program.IsDigit(five);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_9_trueReturned()
        {
            char nine = '9';
            bool expected = true;

            bool actual = Program.IsDigit(nine);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_letter_a_falseReturned()
        {
            char letter = 'a';
            bool expected = false;

            bool actual = Program.IsDigit(letter);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_whitespace_falseReturned()
        {
            char space = ' ';
            bool expected = false;

            bool actual = Program.IsDigit(space);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class isSR3
    {
        [TestMethod]
        public void input_identifier_abc123_trueReturned()
        {
            string identifier = "abc123";
            bool expected = true;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_identifier_A1Z2g3_trueReturned()
        {
            string identifier = "A1Z2g3";
            bool expected = true;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void identifier_is_small_letter_trueReturned()
        {
            string identifier = "z";
            bool expected = true;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void identifier_starts_with_a_digit_falseReturned()
        {
            string identifier = "1a";
            bool expected = false;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void identifier_is_digits_falseReturned()
        {
            string identifier = "123";
            bool expected = false;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void identifier_is_whitespace_falseReturned()
        {
            string identifier = " ";
            bool expected = false;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void invailid_character_trueReturned()
        {
            string identifier = "inv#";
            bool expected = true;

            bool actual = Program.IsSR3(identifier);

            Assert.AreEqual(expected, actual);
        }
    }
}

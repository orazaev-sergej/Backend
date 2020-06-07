using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordStrength.Tests
{
    [TestClass]
    public class CheckArgs
    {
        [TestMethod]
        public void input_one_argument_trueReturned()
        {
            string[] oneArg = new string[] { "one" };
            bool expected = true;

            bool actual = Program.CheckArgs(oneArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_three_arguments_falseReturned()
        {
            string[] threeArg = new string[] { "one", "two", "three" };
            bool expected = false;

            bool actual = Program.CheckArgs(threeArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_two_arguments_falseReturned()
        {
            string[] twoArg = new string[] { "one", "two" };
            bool expected = false;

            bool actual = Program.CheckArgs(twoArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_zero_arguments_falseReturned()
        {
            string[] emptyArg = new string[] { };
            bool expected = false;

            bool actual = Program.CheckArgs(emptyArg);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class PasswordValidation
    {
        [TestMethod]
        public void input_valid_password_TrueReturned()
        {
            string password = "abc123";
            bool expected = true;

            bool actual = Program.PasswordValidation(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_invalid_password_FalseReturned()
        {
            string password = "abc123%";
            bool expected = false;

            bool actual = Program.PasswordValidation(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_empty_password_FalseReturned()
        {
            string password = "";
            bool expected = false;

            bool actual = Program.PasswordValidation(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForAllCharacters
    {
        [TestMethod]
        public void input_6_symbols_24Returned()
        {
            string password = "abc123";
            int expected = 24;

            int actual = Program.GetStrengthForAllCharacters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_1_symbol_4Returned()
        {
            string password = "1";
            int expected = 4;

            int actual = Program.GetStrengthForAllCharacters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_20_symbols_80Returned()
        {
            string password = "1234567890abcdefghtr";
            int expected = 80;

            int actual = Program.GetStrengthForAllCharacters(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForDigits
    {
        [TestMethod]
        public void input_5_digits_and_letters_20Returned()
        {
            string password = "12345abcd";
            int expected = 20;

            int actual = Program.GetStrengthForDigits(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_1_digits_20Returned()
        {
            string password = "1";
            int expected = 4;

            int actual = Program.GetStrengthForDigits(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_only_letters_0Returned()
        {
            string password = "abc";
            int expected = 0;

            int actual = Program.GetStrengthForDigits(password);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class GetStrengthForUpperLetters
    {
        [TestMethod]
        public void input_1_Upper_letters_0Returned()
        {
            string password = "A";
            int expected = 0;

            int actual = Program.GetStrengthForUpperLetters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_3_Upper_letters_out_of_5_4Returned()
        {
            string password = "AbcDF";
            int expected = 4;

            int actual = Program.GetStrengthForUpperLetters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_0_Upper_letters_0Returned()
        {
            string password = "abc123";
            int expected = 0;

            int actual = Program.GetStrengthForUpperLetters(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForLowerLetters
    {
        [TestMethod]
        public void input_1_lower_letters_0Returned()
        {
            string password = "a";
            int expected = 0;

            int actual = Program.GetStrengthForLowerLetters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_3_lower_letters_out_of_5_4Returned()
        {
            string password = "abcDE";
            int expected = 4;

            int actual = Program.GetStrengthForLowerLetters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_0_lower_letters_0Returned()
        {
            string password = "123ABC";
            int expected = 0;

            int actual = Program.GetStrengthForLowerLetters(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForOnlyLetters
    {
        [TestMethod]
        public void input_only_letters_minus5Returned()
        {
            string password = "Abcde";
            int expected = -5;

            int actual = Program.GetStrengthForOnlyLetters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_not_only_letters_0Returned()
        {
            string password = "ab123CDe";
            int expected = 0;

            int actual = Program.GetStrengthForOnlyLetters(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForOnlyDigits
    {
        [TestMethod]
        public void input_only_digits_minus5Returned()
        {
            string password = "12345";
            int expected = -5;

            int actual = Program.GetStrengthForOnlyDigits(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_not_only_digits_minus5Returned()
        {
            string password = "12345abc";
            int expected = 0;

            int actual = Program.GetStrengthForOnlyDigits(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GetStrengthForRepeatedCharacters
    {
        [TestMethod]
        public void input_0_repeated_chars_0Returned()
        {
            string password = "abc";
            int expected = 0;

            int actual = Program.GetStrengthForRepeatedCharacters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_2_repeated_chars_minus2Returned()
        {
            string password = "aabc";
            int expected = -2;

            int actual = Program.GetStrengthForRepeatedCharacters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_4_repeated_chars_minus4Returned()
        {
            string password = "1111";
            int expected = -4;

            int actual = Program.GetStrengthForRepeatedCharacters(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_7_repeated_chars_minus7Returned()
        {
            string password = "ababca1232";
            int expected = -7;

            int actual = Program.GetStrengthForRepeatedCharacters(password);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class PasswordStrengthCheck
    {
        [TestMethod]
        public void input_a_repeated_chars_3Returned()
        {
            string password = "a";
            int expected = 3;

            int actual = Program.PasswordStrengthCheck(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_A_repeated_chars_3Returned()
        {
            string password = "A";
            int expected = 3;

            int actual = Program.PasswordStrengthCheck(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_1_repeated_chars_7Returned()
        {
            string password = "1";
            int expected = 7;

            int actual = Program.PasswordStrengthCheck(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_aBC143_repeated_chars_3Returned()
        {
            string password = "aBC143";
            int expected = 54;

            int actual = Program.PasswordStrengthCheck(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_12345_repeated_chars_3Returned()
        {
            string password = "12345";
            int expected = 35;

            int actual = Program.PasswordStrengthCheck(password);

            Assert.AreEqual(expected, actual);
        }
    }
}

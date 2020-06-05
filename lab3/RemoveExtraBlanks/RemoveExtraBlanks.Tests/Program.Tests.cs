using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveExtraBlanks.Tests
{
    [TestClass]
    public class CheckArg
    {
        [TestMethod]
        public void input_two_arguments_trueReturned()
        {
            string[] twoArg = new string[] { "one", "two" };
            bool expected = true;

            bool actual = Program.CheckArg(twoArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_three_argument_falseReturned()
        {
            string[] twoArg = new string[] { "one", "two", "three" };
            bool expected = false;

            bool actual = Program.CheckArg(twoArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_one_argument_falseReturned()
        {
            string[] twoArg = new string[] { "one" };
            bool expected = false;

            bool actual = Program.CheckArg(twoArg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_zero_arguments_falseReturned()
        {
            string[] twoArg = new string[] {  };
            bool expected = false;

            bool actual = Program.CheckArg(twoArg);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class RemoveExtraBlanks
    {
        [TestMethod]
        public void extra_blanks_at_beginning_must_be_deleted()
        {
            string input = "\t \t extra blanks in text \t  ";
            string expected = "extra blanks in text";

            string actual = "";
            actual = Program.RemoveExtraBlanks(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void extra_blanks_between_words_must_be_deleted()
        {
            string input = "two  extra\t \t blanks   in\t\t text";
            string expected = "two extra blanks in text";

            string actual = "";
            actual = Program.RemoveExtraBlanks(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void extra_blanks_in_two_lines_must_be_deleted()
        {
            string input = "two  \nextra\t blanks  \nin\t text";
            string expected = "two \nextra blanks \nin text";

            string actual = "";
            actual = Program.RemoveExtraBlanks(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void empty_line_returned_empty_line()
        {
            string input = "";
            string expected = "";

            string actual = "";
            actual = Program.RemoveExtraBlanks(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

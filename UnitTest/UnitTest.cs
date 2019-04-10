namespace TaskTest
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task;

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Output_Should_Return_One_Element()
        {
            // Arrange
            var text = "a";

            // Act
            var expected = StringHelper.SplitStringByChars(text);

            // Asset
            var countChars = 1;
            var actual = new List<char> { 'a' };

            Assert.AreEqual(countChars, expected.Item1);
            Assert.IsTrue(expected.Item2.SequenceEqual(actual));
        }

        [TestMethod]
        public void Test_Output_Should_Return_One_Element1()
        {
            // Arrange
            var text = "ababcca";

            // Act
            var expected = StringHelper.SplitStringByChars(text);

            // Asset
            var countChars = 3;
            var actual = new List<char> { 'a' };

            Assert.AreEqual(countChars, expected.Item1);
            Assert.IsTrue(expected.Item2.SequenceEqual(actual));
        }

        [TestMethod]
        public void Test_Output_Should_Return_Two_Elements()
        {
            // Arrange
            var text = "aaabbbc";

            // Act
            var expected = StringHelper.SplitStringByChars(text);

            // Asset
            var countChars = 3;
            var actual = new List<char> { 'a', 'b' };

            Assert.AreEqual(countChars, expected.Item1);
            Assert.IsTrue(expected.Item2.SequenceEqual(actual));
        }

        [TestMethod]
        public void Test_Output_Should_Return_Three_Elements()
        {
            // Arrange
            var text = "abc";

            // Act
            var expected = StringHelper.SplitStringByChars(text);

            // Asset
            var countChars = 1;
            var actual = new List<char> { 'a', 'b', 'c' };

            Assert.AreEqual(countChars, expected.Item1);
            Assert.IsTrue(expected.Item2.SequenceEqual(actual));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text can not be empty or null.")]
        public void Empty_String_Should_Return_Exception()
        {
            var text = "";
            var result = StringHelper.SplitStringByChars(text);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text can not be empty or null.")]
        public void Whitespace_String_Should_Return_Exception()
        {
            var text = "   ";
            var result = StringHelper.SplitStringByChars(text);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text can not contain numbers.")]
        public void String_With_Numbers_Should_Return_Exception()
        {
            var text = "x1yz2xx";
            var result = StringHelper.SplitStringByChars(text);
        }
    }
}

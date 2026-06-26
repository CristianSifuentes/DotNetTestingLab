using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Tests
{
    /// UNIT TESTING LAB - StringOperations
    /// ===================================================
    /// Each test is commented with the idea it demonstrates. Read the comments
    /// in order and you will cover: AAA pattern, Fact vs. Theory, InlineData,
    /// MemberData, exception testing, mocks (Setup / It.IsAny / Verify),
    /// branch coverage, and the Skip attribute.
    // </summary>
    public class StringOperationsTest
    {
        // ══════════════════════════════════════════════════════════════════
        // 1. ConcatenateStrings
        // Demonstrates: the pure AAA pattern + the Skip attribute.
        // ═════════════════════════════════════════════════════════════════
        // Your original version had "permanent" Skip. Remember what
        // we saw: Skip does NOT delete the test, it only temporarily omits it and must
        // include a message explaining why. Here I leave it ACTIVE and
        // working so that it counts towards coverage.
        [Fact]
        //[Fact(Skip = "This test is not valid at this time, TICKET-001")]
        public void ConcatenateStrings_ReturnsBothWordsSeparatedBySpace()
        {
            // Arrange  -> I get what I need ready.
            var strOperations = new StringOperations();

            // Act      -> execute THE action under test (one line)
            var result = strOperations.ConcatenateStrings("Hello", "World");

            // Assert   -> I verify the expected result
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
        }

        // Example of how a properly used Skip would look (temporary and actual blocking).
        // This one is indeed omitted, but the message clearly explains why and with which ticket.
        [Fact(Skip = "Blocked by TICKET-001: pending definition of configurable separator.")]
        public void ConcatenateStrings_WithCustomSeparator_Pending()
        {
            // When the functionality exists, remove the Skip and this will run.
        }

        // ══════════════════════════════════════════════════════════════════
        // 2. IsPalindrome
        // Demonstrates: two facts for the two Boolean paths (true/false)
        // and then how Compact them with a Theory. This is branch coverage.
        // The method has an Equals that can return true or false.
        // ═════════════════════════════════════════════════════════════════════════
        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("ama");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("hello");

            // Assert
            Assert.False(result);
        }

        // Same two cases as above + one extra (uppercase) in a single method.
        // Theory + InlineData = one test, multiple data sets. Cleaner
        // and easier to extend: just add a line and you have another case.
        [Theory]
        [InlineData("ama", true)]
        [InlineData("Ama", true)]     // validates that it is case-insensitive
        [InlineData("reconocer", true)]
        [InlineData("hello", false)]
        [InlineData("platzi", false)]
        public void IsPalindrome_Theory(string input, bool expected)
        {
            var strOperations = new StringOperations();
            var result = strOperations.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        // ════════════════════════════════════════════════════════════════════
        //  3. GetStringLength
        //     Demonstrates: testing the happy path AND the exception path.
        //     If you only test one of the two, your BRANCH coverage remains low.
        // ════════════════════════════════════════════════════════════════════
        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("hello", 5)]
        public void GetStringLength_ReturnsCorrectLength(string input, int expected)
        {
            var strOperations = new StringOperations();
            var result = strOperations.GetStringLength(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetStringLength_Null_ThrowsArgumentNullException()
        {
            var strOperations = new StringOperations();

            // Assert.Throws<T> is stricter than ThrowsAny: it requires the exact type.
            // Use it when you care *which* exception is thrown, not just that it fails.
            Assert.Throws<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        // ════════════════════════════════════════════════════════════════════
        //  4. TruncateString  ★ MOST IMPORTANT FOR BRANCH COVERAGE ★
        //     This method has 4 paths. Each test covers a different one.
        //     Previously, it had no tests => a huge gap in branch coverage.
        // ════════════════════════════════════════════════════════════════════

        [Fact]
        public void TruncateString_MaxLengthZeroOrLess_ThrowsException()
        {
            // BRANCH 1: maxLength <= 0
            var strOperations = new StringOperations();
            Assert.Throws<ArgumentOutOfRangeException>(
                () => strOperations.TruncateString("hello", 0));
        }

                [Fact]
        public void TruncateString_MaxLengthGreaterThanInput_ReturnsFullString()
        {
            // BRANCH 2: maxLength >= length of the input -> returns the full value
            var strOperations = new StringOperations();
            var result = strOperations.TruncateString("hi", 10);
            Assert.Equal("hi", result);
        }

        [Fact]
        public void TruncateString_EmptyInput_ReturnsEmpty()
        {
            // branch 2 (another condition of the same OR): empty string
            var strOperations = new StringOperations();
            var result = strOperations.TruncateString("", 5);
            Assert.Equal("", result);
        }

        [Fact]
        public void TruncateString_NormalCase_TruncatesCorrectly()
        {
            // branch 3: t(another condition of the same OR): empty string

            var strOperations = new StringOperations();
            var result = strOperations.TruncateString("Hello World", 5);
            Assert.Equal("Hello", result);
        }




        [Fact]
        public void QuantintyInWords() 
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.QuantintyInWords("cat", 10);

            //Assert
            Assert.StartsWith("ten", result);
            Assert.Contains("cat", result);
        
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperations = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(()=> strOperations.GetStringLength(null));
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperations = new StringOperations(mockLogger.Object);

            var result = strOperations.CountOccurrences("Hello platzi", 'l');

            Assert.Equal(3, result);
        }

        [Fact]
        public void ReadFile()
        {
            var strOperations = new StringOperations();
            var mockFileReader = new Mock<IFileReaderConnector>();
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file");

            var result = strOperations.ReadFile(mockFileReader.Object, "file2.txt");

            Assert.Equal("Reading file", result);
        }
    }
}

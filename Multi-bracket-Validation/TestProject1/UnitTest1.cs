using System;
using Xunit;
using Multi_bracket_Validation_;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ExampleInputOne()
        {
            string test = "{}";
            Assert.True(Program.ValidateBrackets(test));
        }

        [Fact]
        public void ExampleInputFive()
        {
            string test = "{}{Code}[Fellows](())";
            Assert.True(Program.ValidateBrackets(test));
        }

        [Fact]
        public void ExampleInputSix()
        {
            string test = "[({}]";
            Assert.False(Program.ValidateBrackets(test));
        }

        [Fact]
        public void TestMatchingParens()
        {
            Assert.True(Program.Check('(', ')'));
        }

        [Fact]
        public void TestMatchingBrackets()
        {
            Assert.True(Program.Check('[', ']'));
        }

        [Fact]
        public void TestNoMatch()
        {
            Assert.False(Program.Check('(', ']'));
        }
    }
}

using Testing_module;

namespace Testing_module_Tests
{
    public class EvenOddTests
    {
        [Theory]
        [InlineData(9, "Odd")]
        [InlineData(15, "Odd")]
        [InlineData(21, "Odd")]
        [InlineData(99, "Odd")]
        public void Should_Return_Odd_String(int number, string expected)
        {
            var program = new EvenOddClass();
            var result = program.GetEvenOrOddResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, "Even")]
        [InlineData(14, "Even")]
        [InlineData(18, "Even")]
        [InlineData(96, "Even")]
        public void Should_Return_Even_String(int number, string expected)
        {
            var program = new EvenOddClass();
            var result = program.GetEvenOrOddResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(41)]
        [InlineData(97)]
        public void Should_Throw_Exception_With_Is_Prime_Message(int number)
        {
            var program = new EvenOddClass();
            var ex = Assert.Throws<Exception>(() => program.GetEvenOrOddResult(number));
            Assert.Equal("Argument is prime number", ex.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void Should_Throw_Argument_Exeption_If_Number_Is_Out_Of_Range(int number)
        {
            var program = new EvenOddClass();
            Assert.Throws<ArgumentException>(() => program.GetEvenOrOddResult(number));
        }
    }
}
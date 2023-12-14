using Testing_module;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "7")]
        [InlineData(2, "2")]
        public void Should_Assert_Fizz_Buzz_Success_Test_Cases(int number, string expected)
        {
            var program = new FizzBuzzClass();
            var result = program.GetFizzBuzzResult(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(101)]
        public void Should_Throw_Argument_Exeption_If_Number_Is_Out_Of_Range(int number)
        {
            var program = new FizzBuzzClass();
            Assert.Throws<ArgumentException>(() => program.GetFizzBuzzResult(number));
        }
    }
}
using Testing_module;

namespace Testing_module_Tests
{
    public class HarryPotterTests
    {
        [Fact]
        public void CalculateTotalPrice_EmptyBasket_ShouldReturnZero()
        {
            var program = new HarryPotter();
            int[] basket = { };


            double result = program.CalculateTotalPrice(basket);

            Assert.Equal(0.0, result);
        }

        [Fact]
        public void CalculateTotalPrice_SingleBook_ShouldReturnOriginalPrice()
        {
            var program = new HarryPotter();
            int[] basket = { 1 };


            double result = program.CalculateTotalPrice(basket);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void CalculateTotalPrice_ExampleBasket_ShouldReturnCorrectTotalPrice()
        {
            var program = new HarryPotter();
            int[] basket = { 2, 2, 2, 1, 1 };

            double result = program.CalculateTotalPrice(basket);

            Assert.Equal(51.60, result);
        }
    }
}

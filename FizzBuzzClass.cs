
namespace Testing_module
{
    public class FizzBuzzClass
    {
        public string GetFizzBuzzResult(int number)
        {
            if (number <= 0 || number > 100)
            {
                throw new ArgumentException();
            }

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();

        }
    }
}

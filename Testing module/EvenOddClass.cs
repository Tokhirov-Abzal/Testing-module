using System;


namespace Testing_module
{
    public class EvenOddClass
    {

        public string GetEvenOrOddResult(int num)
        {
            if (num < 0 || num > 100)
            {
                throw new ArgumentException();
            }

            {

            }

            if (IsPrime(num))
            {
                Console.WriteLine(num);
                throw new Exception("Argument is prime number");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("Even");
                return "Even";
            }

            else
            {
                Console.WriteLine("Odd");
                return "Odd";
            }
        }


        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
}

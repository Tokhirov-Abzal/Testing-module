using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing_module
{
    public class HarryPotter
    {
        Dictionary<int, double> discounts = new Dictionary<int, double>{{ 1, 0.0 },
            { 2, 0.05 },
            { 3, 0.1 },
            { 4, 0.2 },
            { 5, 0.25 } };

        double bookPrice = 8.0;

        public double CalculateTotalPrice(int[] basket)
        {
            double totalPrice = 0;

            Array.Sort(basket);

            while (basket.Sum() > 0)
            {
                int uniqueBooks = basket.Count(b => b > 0);

                if (uniqueBooks > 0)
                {
                    double discount = discounts[uniqueBooks];
                    totalPrice += uniqueBooks * (1 - discount) * bookPrice;

                    for (int i = 0; i < basket.Length; i++)
                    {
                        if (basket[i] > 0)
                        {
                            basket[i]--;
                        }
                    }
                }
            }

            return totalPrice;
        }
    }



}
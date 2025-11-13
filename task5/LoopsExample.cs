using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class LoopsExample
    {
        public void SumFrom1ToN()
        {
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {N} = {sum}");
        }

        // 2️⃣ Print numbers from 1 to 20 using while loop
        // Skip multiples of 4 and stop when number is 15
        public void PrintNumbersWithWhile()
        {
            int num = 1;
            while (num <= 20)
            {
                if (num == 15)
                {
                    Console.WriteLine("Reached 15, stopping the loop.");
                    break;
                }

                if (num % 4 == 0)
                {
                    num++;
                    continue; // skip multiples of 4
                }

                Console.WriteLine(num);
                num++;
            }
        }

        // 3️⃣ Find sum of all elements in an array using foreach loop
        public void SumOfArrayElements()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            Console.WriteLine($"Sum of array elements = {total}");
        }
    }
}

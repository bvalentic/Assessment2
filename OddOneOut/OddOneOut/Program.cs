using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program returns a sum and average of all odd numbers between 1 and the specified number.\n" +
                "(This goes up to but does not include the input number.)");
            //math and semantics disclaimer (so input "5" will not include 5 in sum/average)

            Console.Write("Please enter a number: ");

            string stringInput = Console.ReadLine();
            double numInput; 
            //used double to allow for non-whole number inputs (so input "5.5" will include 5 in sum/average)

            while (!double.TryParse(stringInput, out numInput) || double.Parse(stringInput) <= 1)
            {//doesn't allow any input besides a number greater than 1
                Console.Write("Please enter a number greater than 1: ");
                stringInput = Console.ReadLine();
            }
            int sum = GetSum(numInput);//sum and average will always be int

            Console.WriteLine($"The sum of odd numbers from 1 to {numInput} is {sum}.");

            int average = GetAverage(sum, numInput);

            Console.WriteLine($"The average of odd numbers from 1 to {numInput} is {average}.");
            Console.ReadKey();
        }

        static int GetSum(double numInput)
        {//sums odd numbers between 1 and input
            int sum = 0;
            for (int i = 0; i < numInput; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;                    
                }
            }
            return sum;
        }

        static int GetAverage(int sum, double numInput)
        {//counts number of odd numbers between 1 and input, divides sum by that number to get average
            int count = 0;
            for (int i = 0; i < numInput; i++)
            {
                if (i % 2 == 1)
                {
                    count += 1;
                }
            }
            return sum / count; //not worried about divide by 0 because of input validation
            //also technically just returning "count" is the same as the average
        }
    }
}

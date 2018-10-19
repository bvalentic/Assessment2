using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numArray = FillArray();
            GetMax(numArray);
            Console.ReadKey();
        }

        static double[] FillArray()
        {//prompts to create and fill array of numbers; size and content determined by user input

            Console.Write("Enter the number of elements in the array you'd like to create: ");
            string inputString = Console.ReadLine();
            int inputNum;
            while (!int.TryParse(inputString, out inputNum) || int.Parse(inputString) < 0)
            {//forces user to enter positive integer
                Console.Write("Please enter a whole number (greater than 0): ");
                inputString = Console.ReadLine();
            }
            double[] numArray = new double[inputNum];
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write($"Enter a number for position {i + 1} out of {inputNum}: ");
                string newInput = Console.ReadLine();
                double newNum;
                while (!double.TryParse(newInput, out newNum))
                {
                    Console.Write("Please enter a number: ");
                    newInput = Console.ReadLine();
                }
                numArray[i] = newNum;
            }
            return numArray;
        }

        static void GetMax(double[] numArray)
        {//loops through array to find largest value
            double maxNum = numArray[0];
            foreach (var i in numArray)
            {
                if (i > maxNum)
                {
                    maxNum = i;
                }
            }
            Console.WriteLine($"The largest number in the array is {maxNum}.");
        }
    }
}

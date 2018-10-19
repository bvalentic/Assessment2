using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] diagArray = new int[4,4]
            {//the array shown in the assessment
                { 5, -4, 3, 0 },
                { 5, 1, -2, -1 },
                { 8, 6, -7, 4 },
                { -2, 1, -5, 2 },
            };
            
            int sum = SumDiag(diagArray);
            PrintArray(diagArray);
            Console.WriteLine($"\nThe sum of the diagonal of this array is {sum}.");
            Console.ReadKey();
        }
        static int SumDiag(int[,] diagArray)
        {//sums the diagonal numbers of a 2-d array
            int sum = 0;
            for (int i = 0; i < diagArray.GetLength(0); i++)
            {                
                for (int j = 0; j < diagArray.GetLength(1); j++)
                {
                    if (i == j)//the "diagonal" numbers in the array
                    {
                        sum += diagArray[i,j];
                    }
                }
            }
            return sum;
        }
        static void PrintArray(int[,] diagArray)
        {//prints out the array
         //I wanted to see the array in the console, partially for debugging and partially to practice my 2-d array use
            for (int i = 0; i < diagArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < diagArray.GetLength(1); j++)
                {
                    Console.Write($"{diagArray[i, j],3}");
                }
            }
            Console.WriteLine();
        }
    }
}

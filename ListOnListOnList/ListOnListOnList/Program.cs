using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListOnListOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>
            {
                //list of students (unsorted on purpose to see sorting method in action)
                "Joshua Zimmerman",
                "Taylor Everts",
                "Abby Wessels",
                "Rochelle \"Roach\" Toles",
                "Jay Stiles",
                "Shah Shahid",
                "John Shaw",
                "Michael Hern",
                "Nana Banahene",
                "Jordan Owiesny",
                "Tim Broughton",
                "Lin-Z Chang",
                "Madelyn Hilty",
                "Blake Shaw",
                "Bob Valentic",                
            };

            Console.WriteLine("Welcome! This is a list of Dev.Build(2.0) students:\n");
            PrintList(students);            

            bool goAhead = true;
            
            while (goAhead)
            {//allows looping until user wants to quit
                Console.WriteLine($@"
What would you like to do? 
{"add",7} - add student to list
{"list",7} - prints list of students
{"quit",7} - exits program
{"sort",7} - sorts students alphabetically
{"search",7} - searches for student based on input");
                //I have the commands print each loop so the user always knows their options

                string input = Console.ReadLine().ToLower();

                if (input == "list")
                {
                    PrintList(students);
                }
                else if (input == "add")
                {
                    AddToList(students);
                }
                else if (input == "search")
                {
                    SearchList(students);
                }
                else if (input == "sort")
                {
                    students = SortList(students);
                }
                else if (input == "quit")
                {
                    goAhead = Quitter("Are you sure you want to quit? ");
                }
                else Console.WriteLine("I'm sorry, I don't understand.");
            }
        }

        static bool Quitter(string message)
        {//method to check if user wants to quit, returns boolean used as check
            bool correctInput = true; //makes sure user puts in a variation of "yes" or "no"
            bool continuer = true; //eventual returned boolean
            do
            {
                Console.Write("\n" + message);
                string confirm = Console.ReadLine().ToLower();
                if (confirm == "y" || confirm == "yes")
                {
                    Console.WriteLine("Come back soon!");
                    continuer = false;
                    correctInput = true;
                    Console.ReadKey();
                }
                else if (confirm == "n" || confirm == "no")
                {
                    Console.WriteLine("\nOkay!\n");
                    continuer = true;
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't understand.");
                    correctInput = false;
                }
            } while (!correctInput);
            return continuer;
        }

        static void AddToList(List<string> students)
        {//adds a string to the list
            Console.Write("Enter the first and last name of the student you wish to add: ");
            string nameInput = Console.ReadLine();
            while (!Regex.IsMatch(nameInput, @"\w+\s\w+"))//only allows string format "[word][space][word]"
            {
                Console.Write("Please input a first and last name: ");
                nameInput = Console.ReadLine();
            }                
            students.Add(nameInput);
            Console.WriteLine($"{nameInput} has been added to the student list. Thank you!");
        }

        static void SearchList(List<string> students)
        {//searches for a string in the list based on whatever string the user inputs
            Console.Write("Enter name or portion of name you wish to search: ");

            string searchInput = Console.ReadLine().ToLower();
            int nameCount = 0;
            Console.WriteLine("\nStudent name:");
            Console.WriteLine("-------------");
            foreach (string name in students)
            {
                if(name.ToLower().Contains(searchInput))
                {
                    Console.WriteLine(name);
                    nameCount++;
                }
            }
            Console.WriteLine($"\n{nameCount} student(s) found matching \"{searchInput}\".");
        }

        static List<string> SortList(List<string> students)
        {//sorts list alphabetically
            students.Sort();
            Console.WriteLine("The list has been sorted alphabetically:");
            PrintList(students);
            return students;
        }

        static void PrintList(List<string> students)
        {//prints student list (sorted or unsorted depending on if sort method was used or not)
            Console.WriteLine("\nStudent name:");
            Console.WriteLine("-------------");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
        }
    }
}

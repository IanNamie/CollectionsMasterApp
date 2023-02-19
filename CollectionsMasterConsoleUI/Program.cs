using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            
            var numbers = new int[50];

           
            Populater(numbers);

            
            Console.WriteLine($"{numbers[0]}");
                       
            Console.WriteLine($"{numbers[49]}");
            Console.WriteLine("All Numbers Original");
            
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");
            
            Console.WriteLine("All Numbers Reversed:");
            //Array.Reverse(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {//TODO: Create a method that will set numbers that are a multiple 
         //of 3 to zero then print to the console all numbers
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 3 == 0)
                {
                    Console.WriteLine($"{numbers[x] = 0}");
                }else Console.WriteLine($"{numbers[x]}");
                
            }


        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            for( int i = 0; i < numbers.Length; i++  )
            { 
                
                Random rng = new Random();
                numbers[i] = rng.Next(0, numbers.Length);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            
          Array.Reverse(array);
          
          NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

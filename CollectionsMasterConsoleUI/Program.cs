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
            var numberlist = new List<int>() { };

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"1st capacity: {numberlist.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberlist);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {numberlist.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            
            int userNumber;
            bool isANumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (isANumber == false);

            NumberChecker(numberlist,userNumber);

            Console.WriteLine("-------------------");





            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberlist);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberlist);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberlist.Sort();
            NumberPrinter(numberlist);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = numberlist.ToArray();
            //TODO: Clear the list
            numberlist.Clear();
            
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 3 == 0)
                {
                    Console.WriteLine($"{numbers[x] = 0}");
                }else Console.WriteLine($"{numbers[x]}");
                
            }


        }

        private static void OddKiller(List<int> numberlist)
        {//TODO: Create a method that will remove all odd numbers from the list then print results
            for(int i = numberlist.Count-1; i >= 0; i--)
            {
                if (numberlist[i] % 2 != 0)
                {
                    numberlist.RemoveAt(i);
                }
            }
            NumberPrinter(numberlist);
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {//TODO: Create a method that prints if a user number is present in the list
         //Remember: What if the user types "abc" accident your app should handle that!
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($" Yep that number is the list!");
            }
            else
            { Console.WriteLine($"Nope that number is not on the list"); }



        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count <= 50)
            {
                Random rng = new Random();
                
                var number = rng.Next(0,50);
                numberList.Add(number);

            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays.Tutorial
{
    /// <summary>
    /// Put breakpoints on each line and debug to know
    /// how the arrays look behind the scenes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region One dimensional arrays review
            // An array consists of elements of the same type
            int[] arrOne = new int[] { 5, 6, 10, -25 };
            string[] arrTwo = new string[] { "This", "is", "an", "array" };

            // Array of classes
            Person jack = new Person("Jack", 23);
            Person alice = new Person("Alice", 18);
            Person[] people = new Person[] { jack, alice };
            #endregion

            #region Introduction to jagged arrays
            // The following array will have two rows
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[] { 3, 4, 5, 6 };


            // Another way of initializing the array above
            int[][] jaggedArrayTwo = new int[][]
            {
                new int[2],
                new int[] { 3, 4, 5, 6 }
            };

            // This code will not compile
            // int[][] arr = new int[2][3];
            #endregion

            #region Accessing values inside a jagged array
            int[][] numbers =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            // Retrieves values from jagged array
            Console.WriteLine("Row 0, Column 0: " + numbers[0][0]); // 1
            Console.WriteLine("Row 1, Column 2: " + numbers[1][2]); // 4
            Console.WriteLine("Row 2, Column 1: " + numbers[2][1]); // 22

            Console.WriteLine();

            // Sets values to jagged array
            numbers[0][0] = 20;
            numbers[1][2] = -10;

            Console.WriteLine("Row 0, Column 0: " + numbers[0][0]); // 20
            Console.WriteLine("Row 1, Column 2: " + numbers[1][2]); // -10

            #endregion

            Console.ReadLine();
        }
    }
}

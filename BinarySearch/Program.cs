using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 10, 40 }; //initialises an integer array with sorted values
            int target = 10;  //defines the target value to search for
            int index = BinarySearch(numbers, target); //calls the BinarySearch method to search for the target value in the array

            if (index == -1)  //checks if the target value was found in the array
            {
                Console.WriteLine($"Target number {target} could not be found.");
            }

            else
            {
                Console.WriteLine($"Target number {target} found at index position {index + 1}.");
            }
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0; //initialises a "left" variable with value 0 representing the leftmost index of the array
            int right = array.Length - 1; //initialises a "right" variable with the length of the array minus 1 which represents the rightmost index of the array

            while (left <= right) //starts a while loop which continues as long as 'left' is less than or equal to 'right'
            {
                int middle = left + (right - left) / 2; //calculates the middle index of the array

                if (array[middle] == target)
                {
                    return middle;
                }

                
                if (array[middle] < target) //if the target is greater, the left half is ignored
                {
                    left = middle + 1; //updates "left" variable to move the search to the right half of the array
                }
                else //if the target is smaller, the left half is ignored
                {
                    right = middle - 1; //updates "right" variable to move the search to the right half of the array
                }
            }
            return -1;
        }
    }
}
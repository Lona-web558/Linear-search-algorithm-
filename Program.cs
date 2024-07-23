using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 4, 2, 7, 1, 9, 5, 3 };
        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());

        int result = LinearSearch(numbers, target);

        if (result != -1)
        {
            Console.WriteLine($"Number {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Number {target} not found in the array");
        }
    }
}
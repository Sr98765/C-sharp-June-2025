using System;
using System.IO.Pipes;

class Program
{
    static void Main()
    {
        // 1. Declare and initialize an array of 6 integers with any values you like
        int[] num = { 1, 2, 3, 4, 5, 6 };
        num[0] = 10;
        num[5] = 60;
        Console.WriteLine("First: {0}, last: {1}", num[0], num[5]);

        // 2. Create an array of 3 strings representing your favorite fruits.
        string[] fruits = { "apple", "orange", "mango" };
        fruits[1] = "grape";
        Console.WriteLine(fruits[1]);

        // 3. Create a double array with 4 elements representing prices.
        double[] price = { 20.45, 30.45, 40.45, 50.65 };
        price[2] = 0.05;
        Console.WriteLine(price[2]);

        // 4. Create a char array of 5 elements representing grade letters.
        char[] grades = { 'A', 'B', 'C', 'D', 'F' };
        grades[3] = 'A';
        Console.WriteLine(grades[3]);

        // 5. Create a boolean array with 4 values (true or false).
        bool[] values = { true, false, true, false };
        values[0] = false;
        values[2] = false;
        Console.WriteLine("{0},{1}", values[0], values[2]);
    }
}
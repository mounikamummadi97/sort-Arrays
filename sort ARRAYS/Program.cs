// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace sortArray
{
    class array
    {
        static void Main(string[] args)
        {
            int[] mynumber = { 121, 20, 13 };
            string[] fruits = { "mango", "apple", "mosambi" };
            mynumber[0] = 121;
            mynumber[1] = 20;
            mynumber[2] = 13;
            Array.Sort(mynumber);
            //
            //Console.WriteLine(mynumber);
             foreach (int number in mynumber)
            {
            Console.WriteLine(number);
             }
            Array.Sort(fruits);
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

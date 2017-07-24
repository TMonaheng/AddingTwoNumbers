using System;

namespace AddingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 534;

            var addtwonumbers = new Add(num1,num2);
            int sum = addtwonumbers.AddTwoNumbers();
            Console.WriteLine("sum = "+ sum);
            Console.ReadKey();
        }
    }
}
using System;

namespace CSharp_swapping_two_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, temp;

            Console.WriteLine("Enter 1st number:");
            number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter 2nd number:");
            number2 = int.Parse(Console.ReadLine());


            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("1st number is :"+number1);
            Console.WriteLine("2nd number is:"+number2);




        }
    }
}

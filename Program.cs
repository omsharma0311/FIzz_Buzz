using System;

namespace FIzz_Buzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");

            int number = Convert.ToInt32(Console.ReadLine());

            FizzBuzz obj= new FizzBuzz();
            string result = obj.Calculate(number);

            Console.WriteLine(result);
        }
    }
}

using System;

namespace FIzz_Buzz
{
    public class FizzBuzz
    {
        public string Calculate(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "FizzBuzz";
            if (num % 3 == 0)
                return "Fizz";
            if (num % 5 == 0)
                return "Buzz";
            else
                return "";
        }
    }
}
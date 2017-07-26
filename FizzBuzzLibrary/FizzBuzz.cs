using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {

        }

        /// <summary>
        /// Check any number is divisible by 3 and 5
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string CheckNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "Fizz Buzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}

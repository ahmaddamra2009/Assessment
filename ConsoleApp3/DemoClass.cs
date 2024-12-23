using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DemoClass
    {
        //Vowel Count
        public int CountVowels(string word)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
        //Simple adding
        public int SimpleAdding(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

        // factorial
        public long FirstFactorial(int num)
        {
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Simple Evens
        public string SimpleEvens(string num)
        {
            foreach (char digit in num)
            {
                // Check if the character is not even
                if ((digit - '0') % 2 != 0)
                {
                    return "false";
                }
            }
            return "true";
        }

        // OneDecremented
        public int OneDecremented(string str)
        {
            int count = 0;
            // 987776
            // Loop through the string from the second character
            for (int i = 1; i < str.Length; i++)
            {
                // Check if the current digit is one less than the previous digit
                if ((str[i - 1]) - 1 == (str[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

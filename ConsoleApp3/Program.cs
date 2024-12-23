using ConsoleApp3;
using System;
#region VowelCount

class Program
{
    static void Main()
    {

        DemoClass demo = new DemoClass();
        // Vowel
        Console.WriteLine("-------------Vowel ");
        Console.WriteLine("Enter a word:");
        string input = Console.ReadLine();
        
        int vowelCount = demo.CountVowels(input);
        Console.WriteLine($"The number of vowels in the word is: {vowelCount}");
        // End Vower

        // Simple Adding
        Console.WriteLine("---------Simple Adding");
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        int result = demo.SimpleAdding(num);
        Console.WriteLine($"The sum of numbers from 1 to {num} is: {result}");

        // Factorial

        Console.WriteLine("------------- Factorial:");
        Console.WriteLine("Enter a number:");
        int num1 = int.Parse(Console.ReadLine());

        long result1 = demo.FirstFactorial(num1);
        Console.WriteLine($"The factorial of {num1} is: {result1}");

        // SimpleEvens
        Console.WriteLine("------------ SimpleEvens");
        Console.WriteLine("Enter a number:");
        string input1 = Console.ReadLine();

        string result2 = demo.SimpleEvens(input);
        Console.WriteLine($"Are all digits even? {result2}");

        // OneDecremented
        Console.WriteLine("--------------OneDecremented");
        Console.WriteLine("Enter a string of digits:");
        string OneDecrementedinput = Console.ReadLine();

        int OneDecrementedresult = demo.OneDecremented(OneDecrementedinput);
        Console.WriteLine($"Count of digits one less than the previous: {OneDecrementedresult}");
    }


}
#endregion




    

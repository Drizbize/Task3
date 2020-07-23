using System;
using System.Linq;

namespace ConsoleApp1csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // char - one symbol
            // string - array of symbols, you can handle strings like arrays
            char c = 'a';
            string str = "hello, my name is misha";
            string copy = "";

            // this loop will copy 'str' string to another string 'copy'
            // but will not include char 'c'
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != c)
                {
                    copy += str[i];
                }
            }

            Console.WriteLine($"copy string = {copy}");
            Console.ReadKey();

            // write a program, that will find if the word is palindrome
            // palindrome - is a sequence of characters which reads the same backward as forward
            // examples: 'abba', 'madam, I'm adam'
            string inputStr = Console.ReadLine();

            // your code here            
            string reversestr = ""; 
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                reversestr += inputStr[i];
            }
            if (inputStr == reversestr)
                Console.WriteLine("палиндромом.");
            else
                Console.WriteLine("не палиндромом.");
            Console.ReadKey();
        }
    }
}

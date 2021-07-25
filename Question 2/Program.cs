using System;
using System.Numerics;
using System.Text;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to be translated to words: ");
            string input = Console.ReadLine();
            StringBuilder num = new StringBuilder(input);
            
            BigInteger bi = BigInteger.Parse( num.Replace(",", null).ToString() ); // Remove comma to be converted to BigIntiger
            bi.ToWords();   // Remove unnecessary whitespace.
                            // Find a way to deal with commas if entered 
                            // as an input.
                            // 8290000000000000000000000000000000
        }
    }
}

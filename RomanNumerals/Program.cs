using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    class Program
    {
        Dictionary<int, string> RomanNumerals = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90,"MC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please insert the number to be converted to Roman Numeral: ");
                string inputString = Console.ReadLine();
                if (string.IsNullOrEmpty(inputString))
                    return;
                int input = Convert.ToInt32(inputString);
                Program p = new Program();
                string output = p.ConvertToRoman(input);

                Console.Write($"The Roman numeral equivalent is: {output}");
                Console.WriteLine();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred. {ex.Message.ToString()}");
            }
        }

        string ConvertToRoman(int value)
        {
            StringBuilder output = new StringBuilder();

            foreach (var kv in RomanNumerals)
            {
                while (value >= kv.Key)
                {
                    output.Append(kv.Value);
                    value -= kv.Key;
                }
            }
            return output.ToString();
        }
    }
}

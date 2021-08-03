using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    class Program
    {

        static Dictionary<int, string> romanNumeralEquivalents = new Dictionary<int, string> { { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X" },
                                                                     { 40, "XL" }, { 50, "L" }, { 90 ,"XC" }, { 100, "C" }, { 400, "CD" }, { 500, "D" },
                                                                     { 900, "CM" }, { 1000, "M" } };

        //converts integer into a single Roman "digit" in other words replaced 1000nds with M or 900ds with CM and so on
        public static string ReplaceWithRomanNumber(int romanIntegerValue, ref int inputNubmer)
        {
            string result = "";

            int temp = inputNubmer / romanIntegerValue;
            for (int i = 0; i < temp; i++)
            {
                result += romanNumeralEquivalents[romanIntegerValue];
            }
            inputNubmer -= (romanIntegerValue * temp);

            return result;
        }

        //gets a whole number and returns its roman equivalent
        public static string ReplaceIntegerWithRomanNumber(int input)
        {
            string result = "";

            result += ReplaceWithRomanNumber(1000, ref input);
            result += ReplaceWithRomanNumber(900, ref input);
            result += ReplaceWithRomanNumber(500, ref input);
            result += ReplaceWithRomanNumber(400, ref input);
            result += ReplaceWithRomanNumber(100, ref input);
            result += ReplaceWithRomanNumber(90, ref input);
            result += ReplaceWithRomanNumber(50, ref input);
            result += ReplaceWithRomanNumber(40, ref input);
            result += ReplaceWithRomanNumber(10, ref input);
            result += ReplaceWithRomanNumber(9, ref input);
            result += ReplaceWithRomanNumber(5, ref input);
            result += ReplaceWithRomanNumber(4, ref input);
            result += ReplaceWithRomanNumber(1, ref input);

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer less than or equal to 3999, which will be transformed into a Roman Number: ");
            int input = int.Parse(Console.ReadLine());
            if (input > 0 && input < 4000)
            {
                Console.WriteLine(ReplaceIntegerWithRomanNumber(input));
            }
            else
            {
                Console.WriteLine("There is no Roman Equivalent to that number.");
            }


        }
    }
}

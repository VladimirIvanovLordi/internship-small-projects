using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            //string result = "";
            StringBuilder resultBuilder = new StringBuilder("");

            int temp = inputNubmer / romanIntegerValue;
            for (int i = 0; i < temp; i++)
            {
                resultBuilder.Append(romanNumeralEquivalents[romanIntegerValue]);
            }
            inputNubmer -= (romanIntegerValue * temp);

            return resultBuilder.ToString();
        }

        //gets a whole number and returns its roman equivalent
        public static string ReplaceIntegerWithRomanNumber(int input)
        {
            StringBuilder resultBuilder = new StringBuilder("");
            IEnumerable<int> numbersReadyForUse = romanNumeralEquivalents.Keys.Reverse();
            foreach (int romanNumberValue in numbersReadyForUse)
            {
                //TODO go through the dictionary using the key values in a reverse order
                resultBuilder.Append(ReplaceWithRomanNumber(romanNumberValue, ref input));
            }

            return resultBuilder.ToString();
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

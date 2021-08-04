using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IntegerToWords
{
    class Program
    {
        public static Dictionary<int, string> numberWordEquivalents = new Dictionary<int, string> { { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three" },
                                                            { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, 
                                                            { 9, "nine" }, { 10, "ten" }, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen" },
                                                            { 14, "fourteen" }, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen" },
                                                            { 18, "eighteen" }, { 19, "nineteen" }, { 20, "twenty" }, { 30, "thirty" },
                                                            { 40, "forty" }, { 50, "fifty" }, { 60, "sixty" }, { 70, "seventy" }, { 80, "eighty" },
                                                            { 90, "ninety" }, { 100, "hundred" }, { 1000, "thousand" }, { 1000000, "million" },
                                                            { 1000000000, "billion" }};

        // I realised too late that for hundred, thousand, million and billion it would be easier to just add them directly as strings

        public static string TransformIntegerToWords(int input)
        {
            StringBuilder numberInWords = new StringBuilder();
            int temp;

            if (input < 20)
            {
                numberInWords.Append(numberWordEquivalents[input]);
            }
            else if (input < 100)
            {
                //abusing the fact that it is integer therefore rounding it to the lower ten
                //example: 58 would become 50 after this calculation
                //this is used in the other else if statements as well
                temp = (input / 10) * 10;
                if ( input == temp)
                {
                    numberInWords.Append(numberWordEquivalents[temp]);
                }
                else
                {
                    numberInWords.Append(numberWordEquivalents[temp] + "-");
                    numberInWords.Append(TransformIntegerToWords(input - temp));
                }
            }
            else if (input < 1000)
            {
                temp = (input / 100);
                if (input == temp * 100)
                {
                    numberInWords.Append(numberWordEquivalents[temp] + " ");
                    numberInWords.Append(numberWordEquivalents[100]);
                }
                else
                {
                    numberInWords.Append(numberWordEquivalents[temp] + " ");
                    numberInWords.Append(numberWordEquivalents[100] + " and ");
                    numberInWords.Append(TransformIntegerToWords(input - temp * 100));
                }
            }
            else if (input < 1000000)
            {
                temp = (input / 1000);
                if (input == temp * 1000)
                {
                    numberInWords.Append(TransformIntegerToWords(input / 1000) + " ");
                    numberInWords.Append(numberWordEquivalents[1000]);
                }
                else
                {
                    numberInWords.Append(TransformIntegerToWords(input / 1000) + " ");
                    numberInWords.Append(numberWordEquivalents[1000] + " ");
                    numberInWords.Append(TransformIntegerToWords(input - temp * 1000));
                }
            }
            else if (input < 1000000000)
            {
                temp = (input / 1000000);
                if (input == temp * 1000000)
                {
                    numberInWords.Append(TransformIntegerToWords(input / 1000000) + " ");
                    numberInWords.Append(numberWordEquivalents[1000000]);
                }
                else
                {
                    numberInWords.Append(TransformIntegerToWords(input / 1000000) + " ");
                    numberInWords.Append(numberWordEquivalents[1000000] + " ");
                    numberInWords.Append(TransformIntegerToWords(input - temp * 1000000));
                }
            }
            else if (input == 1000000000)
            {
                numberInWords.Append("one " + numberWordEquivalents[1000000000]);
            }

            return numberInWords.ToString();
        }

        static void Main(string[] args)
        {
            //Transform a positive integer from 0 to 1 000 000 000 into words.
            // example: input 125 transforms into -   one hundred and twenty-five

            // idea:   work with the logic of Roman numbers add numbers/words bil, mil, thousand, hundred, 1-20 into a dictionary...
            int input;

            do
            {
                Console.Write("Enter an integer between 1 and 1 000 000 000: ");
                input = int.Parse(Console.ReadLine());
            } while (input < 0 || input > 1000000000);

            Console.WriteLine(TransformIntegerToWords(input));

        }
    }
}

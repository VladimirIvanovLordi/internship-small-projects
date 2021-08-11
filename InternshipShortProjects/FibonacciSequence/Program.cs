using System;

namespace FibonacciSequence
{
    class Program
    {
        //the methods below are made with the assumption that there will be no input of 0

        //the fibonacci sequence can be done with a cycle as well I am assuming I am supposed to do it with recursion
        //also this is not at all an efficient recursion(starts struggling at numbers above 40) but it is the simplest one I could think of.
        public static long CalculateFibonacciSequenceNumber(long numberInSequence)
        {
            if (numberInSequence == 1 || numberInSequence == 2)
            {
                return 1;
            }

            return CalculateFibonacciSequenceNumber(numberInSequence - 1) + CalculateFibonacciSequenceNumber(numberInSequence - 2);
        }

        //this is the Fibonacci Sequence with a cycle which is much more efficient than the one above ^
        public static long CycleFibSequence(long numberInSequence)
        {
            long firstNumber = 1;
            long secondNumber = 1;
            for (int i = 2; i < numberInSequence; i++)
            {
                long temp = firstNumber;
                firstNumber += secondNumber;
                secondNumber = temp;
            }
            return firstNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter which number in the Fibonacci Sequence you want to be printed: ");
            long numberInSequence = long.Parse(Console.ReadLine());

            //Console.WriteLine(CalculateFibonacciSequenceNumber(numberInSequence));
            //Console.WriteLine(CycleFibSequence(numberInSequence));
        }
    }
}

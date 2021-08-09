using System;
using System.Collections.Generic;

namespace InterfaceImplementations
{
    class Program
    {
        static void Main(string[] args)
        {

            //testing the functionality of my custom list

            CustomList<int> testTime = new CustomList<int>();

            for (int i = 0; i < 10; i++)
            {
                testTime.Add(i);
            }

            Console.WriteLine(testTime.Find(4));
            Console.WriteLine(testTime.Count);    

            testTime.Insert(2, 500);

            Console.WriteLine(testTime.Find(4));
            Console.WriteLine(testTime.Count);
            Console.WriteLine();

            testTime.Remove(1100);
            testTime.Remove(2);

            

            foreach (var item in testTime)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
            //can add new lines with Environment.NewLine


            for (int i = 0; i < testTime.Count; i++)
            {
                Console.WriteLine(testTime[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortAndSearchTasks
{
    //5 3 1 22 35 43 2 2     (64)
    //___________________
    //3 5
    //3 1 5
    //3 1 5 22
    //3 1 5 22 35
    //3 1 5 22 35 43
    //3 1 5 22 35 2 43
    //

    class Program
    {
        #region BinarySearch
        
        //helped myself with the internet for the binary search(mainly didn't think of using left and right to track for the arrays)
        public static int IterativeBinarySearch(int searchedNumber, int[] sortedNumberArray)
        {
            int middleNumberIndex = -1;
            int leftEdge = 0;
            int rightEdge = sortedNumberArray.Length - 1;
            while (leftEdge <= rightEdge)
            {
                middleNumberIndex = (leftEdge + rightEdge) / 2;
                if (searchedNumber == sortedNumberArray[middleNumberIndex])
                {
                    return middleNumberIndex;
                }

                if (searchedNumber > sortedNumberArray[middleNumberIndex])
                {
                    leftEdge = middleNumberIndex + 1;
                }
                else
                {
                    rightEdge = middleNumberIndex - 1;
                }
            }

            return -1;
        }

        //used for the user side of the recursive binary search (the user doesn't need to add left and right edge)
        public static int RecursiveBinarySearch(int searchedNumber, int[] sortedNumberArray)
        {
            return RecursiveBinarySearch(searchedNumber, sortedNumberArray, 0, sortedNumberArray.Length - 1);
        }

        //used for the internal logic of the recursive binary search (decided not to make it private)
        public static int RecursiveBinarySearch(int searchedNumber, int[] sortedNumberArray, int leftEdge, int rightEdge)
        {
            if (leftEdge <= rightEdge)
            {
                int middleNumberIndex = (leftEdge + rightEdge) / 2;
                if (sortedNumberArray[middleNumberIndex] == searchedNumber)
                {
                    return middleNumberIndex;
                }

                if (searchedNumber > sortedNumberArray[middleNumberIndex])
                {
                    return RecursiveBinarySearch(searchedNumber, sortedNumberArray, middleNumberIndex + 1, rightEdge);
                }
                else
                {
                    return RecursiveBinarySearch(searchedNumber, sortedNumberArray, leftEdge, middleNumberIndex - 1);
                }
            }
            return -1;
        }

        #endregion

        #region SortingMethods


        public static void IterativeSelectionSort(int[] arrayToBeSorted)
        {
            int indexOfMin;
            for (int i = 0; i < arrayToBeSorted.Length - 1; i++)
            {
                indexOfMin = i;
                for (int j = i + 1; j < arrayToBeSorted.Length; j++)
                {
                    if (arrayToBeSorted[indexOfMin] > arrayToBeSorted[j])
                    {
                        indexOfMin = j;

                    }
                }
                int temp = arrayToBeSorted[i];
                arrayToBeSorted[i] = arrayToBeSorted[indexOfMin];
                arrayToBeSorted[indexOfMin] = temp;
            }
        }

        //used for the user side
        public static void RecursiveSelectionSort(int[] arrayToBeSorted)
        {
            RecursiveSelectionSort(arrayToBeSorted, 0);
        }
        //used for the logical side
        public static void RecursiveSelectionSort(int[] arrayToBeSorted, int currentNumberIndex)
        {
            if (currentNumberIndex == arrayToBeSorted.Length - 1)
            {
                return;
            }

            int indexOfMin = currentNumberIndex;
            for (int i = currentNumberIndex + 1; i < arrayToBeSorted.Length; i++)
            {
                if (arrayToBeSorted[indexOfMin] > arrayToBeSorted[i])
                {
                    indexOfMin = i;
                }
            }

            int temp = arrayToBeSorted[currentNumberIndex];
            arrayToBeSorted[currentNumberIndex] = arrayToBeSorted[indexOfMin];
            arrayToBeSorted[indexOfMin] = temp;

            RecursiveSelectionSort(arrayToBeSorted, currentNumberIndex + 1);
        }



        //for the Bubble Sort I needed some help from the internet and found out I had a misunderstanding of how it worked
        //basically when I was going for ascending order
        //I didn't realise that the largest numbers were sorted first (which is why I had problems with this sorting type in the past)
        //sooooo I learned something new :)

        //I helped myself with the internet for arrayToBeSorted.Length - i part as I didn't realise it could be optimized this way
        //as a result the method is more efficient
        public static void IterativeBubbleSort(int[] arrayToBeSorted)
        {
            for (int i = 0; i < arrayToBeSorted.Length - 1; i++)
            {
                for (int j = 0; j < arrayToBeSorted.Length - i - 1; j++)
                {
                    if (arrayToBeSorted[j] > arrayToBeSorted[j + 1])
                    {
                        int temp = arrayToBeSorted[j];
                        arrayToBeSorted[j] = arrayToBeSorted[j + 1];
                        arrayToBeSorted[j + 1] = temp;
                    }
                }
            }
        }

        //for the user end
        public static void RecursiveBubbleSort(int[] arrayToBeSorted)
        {
            RecursiveBubbleSort(arrayToBeSorted, arrayToBeSorted.Length);
        }
        //for the logical side
        public static void RecursiveBubbleSort(int[] arrayToBeSorted, int notYetSortedEndIndex)
        {
            if (notYetSortedEndIndex == 1)
            {
                return;
            }

            for (int i = 0; i < notYetSortedEndIndex - 1; i++)
            {
                if (arrayToBeSorted[i] > arrayToBeSorted[i + 1])
                {
                    int temp = arrayToBeSorted[i];
                    arrayToBeSorted[i] = arrayToBeSorted[i + 1];
                    arrayToBeSorted[i + 1] = temp;
                }
            }

            RecursiveBubbleSort(arrayToBeSorted, notYetSortedEndIndex - 1);
        }
        #endregion

        static void Main(string[] args)
        {
            int[] testNumbers = {1, 5, 3, 42, 22, 11, 3, 2, 2, 2, 5, 6, 12};

            RecursiveSelectionSort(testNumbers);

            foreach (int number in testNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("_______________________________________");

            Console.WriteLine(RecursiveBinarySearch(11, testNumbers));
            Console.WriteLine(IterativeBinarySearch(29, testNumbers));


        }
    }
}

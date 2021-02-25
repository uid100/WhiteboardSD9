using System;

namespace ArraySort
{
    public class Arrays
    {
        static Random r = new Random();

        public static int[] GetIntArray() => GetIntArray(r.Next());
        public static int[] GetIntArray(int ArrayLength)
        {
            int[] num = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                num[i] = r.Next();
            }

            return num;
        }

        public static int[] IntegerArraySort( int[] num )
        {
            Array.Sort(num);
            return num;
        }

        public static int[] IntegerSort( int[] numbers )
        {
            int[] SortedArray = new int[numbers.Length];

            int somethingBig = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int min = findMinPos(numbers);
                SortedArray[i] = numbers[min];
                numbers[min] = somethingBig;
            }
            return SortedArray;
        }

        // return the index of the smallest value int the array
        public static int findMinPos(int[] myList)
        {
            int index = 0;
            int smallest = myList[index];

            for (int i = 1; i < myList.Length; i++)
            {
                if (myList[i] < smallest)
                {
                    smallest = myList[i];
                    index = i;
                }
            }
            return index;
        }
    }
}

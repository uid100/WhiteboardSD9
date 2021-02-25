using System;

namespace ArrayMethods
{
    public class ArrayClass
    {
        // create a method to output an array of integers as a 
        // string of comma-separated values.
        // example: {4,8,9,2,3,5}   -->  "4,8,9,2,3,5"
        public static string ArrayToCSV(int[] intArray)
        {
            string csv = "";
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                csv += intArray[i] + ",";
            }
            csv += intArray[intArray.Length - 1];
            return csv;
        }

        public static int[] CopyArray(int[] numbers)
        {
            int[] copy = new int[numbers.Length];
            int i = 0;
            foreach (int n in numbers)
            {
                copy[i++] = n;
            }
            return copy;
        }

        // create a method to calculate and return as double the
        // average value from an array of integers
        public static double GetArrayAverage(int[] numbers)
        {
            return (double)GetArraySum(numbers) / (double)numbers.Length;
        }

        // create a method to calculate and return the sum of a
        // given array of integers
        public static int GetArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += x;
            }
            return sum;
        }

        // instead of: Array.Max()  (System.Linq)
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int x in numbers) max = max < x ? x : max;
            return max;
        }

        public static int GetMaxPos(int[] x)
        {
            int index = 0;
            int largest = x[index];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > largest)
                {
                    index = i;
                    largest = x[i];
                }
            }
            return index;
        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int x in numbers) min = min > x ? x : min;
            return min;
        }

        public static int GetMinPos(int[] x)
        {
            int index = 0;
            int smallest = x[index];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < smallest)
                {
                    index = i;
                    smallest = x[i];
                }
            }
            return index;
        }

        // print an integer array to the Console
        public static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }

        // create a method to print an array of integers
        // in reverse order
        public static void PrintReverseArray(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine(numbers[0]);
        }

        public static int[] RandomIntArray(int size=10, int seed = 0)
        {
            int[] x = new int[size];

            Random r = (seed != 0) ? new Random(seed) : new Random();
            for (int i = 0; i < size; i++) x[i] = r.Next();
            return x;
        }

        // return an integer array in reverse order
        public static int[] ReverseArray(int[] numbers)
        {
            int[] backwards = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                backwards[i] = numbers[numbers.Length - 1 - i];
            }
            return backwards;
        }

        // rotate an array right or left using positive
        // or negative number of steps
        public static int[] RotateArray(int nrSteps, int[] numbers)
        {
            int len = numbers.Length;
            int[] rotated = new int[len];
            for (int i = 0; i < len; i++)
            {
                rotated[i] = numbers[(i - nrSteps % len + len) % len];
            }
            return rotated;
        }

        // rotate an array (3 parameter overload)
        public static int[] RotateArray(string direction, int nrSteps, int[] numbers)
        {
            if (direction.ToLower() == "left")
            {
                nrSteps = -nrSteps;
            }
            return RotateArray(nrSteps, numbers);
        }

        public static int[] SortIntArray(int[] numbers)
        {
            // method is destructive to input parameter. work from copy.
            int[] copy = CopyArray(numbers);
            int[] sorted = new int[copy.Length];
            int bigNumber = GetMax(copy) + 1;
            for (int i = 0; i < copy.Length; i++)
            {
                int j = GetMinPos(copy);
                sorted[i] = copy[j];
                copy[j] = bigNumber;
            }
            return sorted;
        }

        public static int[] SortIntArrayDesc(int[] numbers)
        {
            int[] copy = CopyArray(numbers);
            int[] sorted = new int[copy.Length];
            int smallNumber = GetMin(copy) - 1;
            for (int i = 0; i < copy.Length; i++)
            {
                int j = GetMaxPos(copy);
                sorted[i] = copy[j];
                copy[j] = smallNumber;
            }
            return sorted;
        }


        /// <summary>
        /// Try each of the methods in the context of the exercise.
        /// outputs to Console.
        /// </summary>
        public static void TestMethodsForEx6A()
        {
            int[][] myNumbers = new int[][]
            {
                new int[] { 0, 2, 4, 6, 8, 10 },
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }
            };

            for (int i = 0; i < myNumbers.Length; i++)
            {
                // (0.) Print the array
                Console.Write($"Array{i + 1}: ");
                PrintArray(myNumbers[i]);

                // (1.) Print the average
                Console.WriteLine($"Array{i + 1} (average): {GetArrayAverage(myNumbers[i])}");

                // (2.) Print the reverse
                Console.Write($"Array{i + 1} (reversed): ");
                // (2a.) or.. reverse and then print
                PrintReverseArray(myNumbers[i]);
                Console.Write($"Array{i + 1} (reversed v(2)): ");
                PrintArray(ReverseArray(myNumbers[i])); 

                // (3.) rotate both directions ... and (3a.) test overloads
                int len = myNumbers[i].Length;
                for (int j = -len/2; j < len/2; j++)
                {
                    if (j == 0) continue;
                    string dir = $"{(j < 0 ? "left" : "right")}";
                    Console.Write($"Array{i + 1} (rotated {dir}) {j}x v(1): ");
                    PrintArray(RotateArray($"{dir}", Math.Abs(j), myNumbers[i]));
                    Console.Write($"Array{i + 1} (rotated {dir}) {j}x v(2): ");
                    PrintArray(RotateArray(j, myNumbers[i]));
                }

                // (4.) sort and print
                Console.WriteLine($"Arr{i + 1} sorted: ");
                PrintArray(SortIntArray(myNumbers[i]));
                Console.WriteLine($"Arr{i + 1} sorted-desc: ");
                PrintArray(SortIntArrayDesc(myNumbers[i]));

                // separator between each sample array
                Console.WriteLine();
            }
        }
    }
}

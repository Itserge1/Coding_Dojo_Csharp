using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumber();
            // PrintOdd();
            // PrintSum();
            int [] numArray = new int [] {1,5,10,-9,5};
            // LoopsArray(numArray);
            // Console.WriteLine(FindMax(numArray));
            // GetAverage(numArray);
            // Console.WriteLine(OddArray());
            // Console.WriteLine(GreaterThanY(numArray, 3));
            // SquareArrayValue(numArray);
            // EliminateNegative(numArray);
            // MinMaxAverage(numArray);
            // ShiftValues(numArray);
            NumToString(numArray);
        }
        public static void PrintNumber()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        // Print odd number

        public static void PrintOdd()
        {
            for (int i = 0; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        // Print he sum of all number.

        public static void PrintSum()
        {
            int sum = 0;
            int i = 0;
            while (i < 256)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
        }

        // iterating thought an array
        public static void LoopsArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // Finf maximun of an array

        public static int FindMax(int[] numbers)
        {
            int max =numbers[0];
            for(int i=0; i<numbers.Length; i++)
            {
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        // Find avarage

        public static void GetAverage(int [] numbers)
        {
            int sum=0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum+=numbers[i];
            }
            Console.WriteLine(sum/numbers.Length);
        }

        // Create array with odd num

        public static  int[] OddArray()
        {
            int [] NewArray = new int[128];
            int j =0;
            for (int i=0; i<256; i++)
            {
                if (i%2 != 0)
                {
                    NewArray[j] = i;
                    j++;
                }
            }
            // LoopsArray(NewArray);
            return NewArray;
        }

        // // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        // That are greater than the "y" value. 

        public static int GreaterThanY (int[] numbers, int y)
        {
            int [] NewArray = new int[numbers.Length];
            int j = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] > y)
                {
                    j++;
                }
            }
            return j;
        }

        public static int[] SquareArrayValue (int[] number)
        {
            for (int i=0; i<number.Length; i++)
            {
                number[i] = number[i] * number[i];
            }

            for (int i=0; i<number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            return number;
        }

        public static void EliminateNegative ( int[] number)
        {
            for(int i=0; i<number.Length; i++)
            {
                if(number[i] < 0)
                {
                    number[i] = 0;
                }
            }

            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }

        public static void MinMaxAverage(int [] number)
        {
            int min = number[0];
            int max = number[0];
            int sum = number[0];

            for(int i=0; i<number.Length; i++)
            {
                sum+= number[i];

                if(number[i]< min)
                {
                    min = number[i];
                }
                else if(number[i]> max)
                {
                    max = number[i];
                }
            }

            Console.WriteLine("min: "+ min + " max: " + max + " average: " + sum/number.Length);
        }

        public static  int[] ShiftValues(int[] number)
        {
            for(int i=0; i<number.Length; i++)
            {
                if(i != number.Length-1)
                {
                    number[i] = number[i+1];
                } else
                {
                    number[i] = 0;
                }
            }

            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            return number;
        }

        public static object[] NumToString(int[] number)
        {
            object[] arr = new object[number.Length];
            for (int i=0; i<number.Length; i++)
            {
                if(number[i] < 0)
                {
                    arr[i] = "Dojo";
                } else
                {
                    arr[i] = number[i];
                }
            }

            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }
    }
}

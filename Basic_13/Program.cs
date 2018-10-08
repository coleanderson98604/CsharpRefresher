using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = {1,3,5,7,9,13,-1,-2};
            object[] test2 = {1,3,5,7,9,13,-1,-2};
            int[] test3 = new int[10];
            Console.WriteLine("Hello World!");
            print1255();
            printodd1255();
            printsum();
            IteratingArray(test1);
            FindMax(test1);
            Average(test1);
            List<int> NewList = ListOdd();
            GreaterThanY(test1, 4);
            squarevalues(test1);
            RemoveNegative(test1);
            MinMaxAverage(test1);
            int[] newarray = ShiftToLeft(test1);
            object[] newobject = NumToStr(test2);
            RandomValues(test3);
            System.Console.WriteLine(TossCoinMultiple(10));

        }
        public static void print1255()
        {
            for (int i = 0; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void printodd1255()
        {
            for (int i = 0; i < 256; i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void printsum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void IteratingArray(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
        public static void FindMax(int[] array)
        {
            if(array.Length < 1)
            {
                System.Console.WriteLine("Array must be populated");
                return;
            }
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            System.Console.WriteLine($"This is the max ${max}");

        }
        public static void Average(int[] array)
        {
            if(array.Length < 1)
            {
                System.Console.WriteLine("Array must be populated");
                return;
            }
            int sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum/array.Length;
            System.Console.WriteLine($"The average is{sum}");
        }
        public static List<int> ListOdd()
        {
            List<int> oddnumbers = new List<int>();
            for (int i = 0; i < 256; i++)
            {
                if(i % 2 != 0)
                {
                    oddnumbers.Add(i);
                }
            }
            return oddnumbers;
        }
        public static void GreaterThanY(int[] array, int y)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(y > array[i])
                {
                    count++;
                }
            }
            System.Console.WriteLine($"{count} this many values are greater than the given value");
        }
        public static int[] squarevalues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
            return array;
        }
        public static int[] RemoveNegative(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] = 0;
                }
            }
            return array;
        }
        public static void MinMaxAverage(int[] array)
        {
            int min, max, average;
            min = max = average = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
                if(max < array[i])
                {
                    max = array[i];
                }
                average += array[i];
            }
            average /= array.Length;
            System.Console.WriteLine($"min: {min} max: {max} average: {average}");
        }
        public static int[] ShiftToLeft(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
                if(i + 1 == array.Length -1)
                {
                    array[i + 1] = 0;
                }
            }
            return array;
        }
        public static object[] NumToStr(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] is int)
                {
                    if((int)array[i] < 0)
                    {
                        array[i] = "cole";
                    }   
                }   
                else{
                    return array;
                }    
            }
            return array;
        }
        public static int[] RandomValues(int[] array)
        {
            int min,max,sum;
            min=max=sum=0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(5,26);
                if(i == 0)
                {
                    min=max= array[i];
                }
                sum += array[i];
            }
            System.Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
            return array;

        }
        public static double TossCoinMultiple(int Attempts)
        {
            int heads,tails,InitalAttempts;
            double result;
            InitalAttempts = Attempts;
            heads=tails=0;
            Random rand = new Random();
            while(Attempts > 0)
            {
                Attempts--;
                if(rand.Next(0,2) == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            result = heads/InitalAttempts;
            return result;
        }
    }
}

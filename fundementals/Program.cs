using System;
using System.Collections.Generic;

namespace CsharpRefresher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a loop that prints all values from 1-255
            // for(int i = 0; i < 256; i++){
            //     // Console.WriteLine(i);
            // }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            // for(int i = 0; i < 101; i++){
            //     if( (i % 3 == 0) && (i % 5 == 0)){
            //         continue;
            //     }
            //     else if( (i % 3 == 0) || (i % 5 == 0)){
            //         Console.WriteLine(i);
            //     }
            // }
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for muliples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            // for(int i = 1; i < 101; i++){
            //     if( (i % 3 == 0) && (i % 5 == 0)){
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if(i % 3 == 0){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if(i % 5 == 0){
            //         Console.WriteLine("Buzz");
            //     }
            // }
            //
            // Three Basic Arrays
            // values 0-9
            // array of names
            // array of true false
            //
            // int i = 0;
            // int[] numArray = new int[10];
            // while (i < numArray.Length)
            // {
            //     numArray[i] = i;
            //     i++;
            // }
            // int i = 0;
            string[] nameArray = {"Tim","Martin","Nikki","Sara"};
            // bool[] truefalseArray = new bool[10];
            // while( i < truefalseArray.Length)
            // {
            //     if(i % 2 == 0)
            //     {
            //         truefalseArray[i] = true;
            //     }
            //     i++;
            // }
            // Three List
            List<string> icecreamflavors = new List<string>();
            icecreamflavors.Add("Chocolate");
            icecreamflavors.Add("Strawberry");
            icecreamflavors.Add("Cherry");
            icecreamflavors.Add("Raspberry");
            icecreamflavors.Add("BlueBerry");
            // System.Console.WriteLine(icecreamflavors.Count);
            // System.Console.WriteLine(icecreamflavors[3]);
            // icecreamflavors.RemoveAt(3);
            // System.Console.WriteLine(icecreamflavors.Count);
            // Info Dictionary
            Random rand = new Random();
            Dictionary<string,string> profile = new Dictionary<string,string>();
            profile.Add("Tim",null);
            profile.Add("Martin",null);
            profile.Add("Nikki",null);
            profile.Add("Sara",null);
            for (int i = 0; i < nameArray.Length; i++)
            {
                profile[nameArray[i]] = icecreamflavors[rand.Next(0,icecreamflavors.Count)];
            }
            foreach(KeyValuePair<string,string> entry in profile)
            {
                System.Console.WriteLine($"{entry.Key} likes the ice cream flavor {entry.Value}");
            }
        }
    }
}

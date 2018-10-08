using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> emptylist = new List<object>();
            emptylist.Add(7);
            emptylist.Add(28);
            emptylist.Add(-1);
            emptylist.Add(true);
            emptylist.Add("Chair");
            var sum = 0;
            for (int i = 0; i < emptylist.Count; i++)
            {
                System.Console.WriteLine(emptylist[i]);
                if(emptylist[i] is int)
                {
                    sum += (int)emptylist[i];
                }
            }
            System.Console.WriteLine(sum);            
        }
    }
}

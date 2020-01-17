using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            List<Int32> even = new List<int>();
            List<Int32> odd = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the numbers:");

                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a;
            for (a = 0; a < num.Length; a++)
            {
                if (num[a] % 2 == 0)
                {
                    even.Add(num[a]);
                }
                else
                    odd.Add(num[a]);
            }

            Console.Write("Even number:");
            foreach(int numb in even){
                Console.Write(numb+" ");
            }
            Console.ReadLine();
            Console.Write("Odd number:");
            foreach (int numb1 in odd)
            {
                Console.Write(numb1 + " ");
            }
            Console.ReadLine();
        }
    }
}


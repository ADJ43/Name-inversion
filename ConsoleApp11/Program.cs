using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and press enter");
            var name = Console.ReadLine();

            var length = name.Length;

            string[] array = new string[length];

            for (int i = length -1; i >= 0; i--)
            {
                array[i] = name[i].ToString();
            }


            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DisplayTable_Of_Number
{
    class Program
    {
        //Write a C# Sharp program that takes a number as input and print its multiplication table

        static void Main(string[] args)
        {
            Console.WriteLine("***Display Table***\n");
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine("{0} x {1} = {2}",number, i, result);
                
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Введите 1 число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                int b = Convert.ToInt32(Console.ReadLine());
                int summ = a * b;
                Console.WriteLine("Умножение двух чисел =" + summ);
                Console.ReadKey();

            }
            catch (OverflowException)
            {

                Console.WriteLine("Возникло переполнение.");
                Console.ReadLine();

            }


        }
        

            

        
      
    }
}

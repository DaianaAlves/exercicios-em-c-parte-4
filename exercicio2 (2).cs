using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero qualquer:");
            double num = Convert.ToDouble(Console.ReadLine());
            if((num % 3 == 0) &&(num % 7 == 0))
            {
                Console.WriteLine("Numero multiplo de 3 e 7");

            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 e 7)");
            }
            Console.ReadKey();
        }
    }
}

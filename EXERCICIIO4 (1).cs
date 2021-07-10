using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4.aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A PRIMEIRA NOTA:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE A segunda NOTA:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE A terceira NOTA:");
            double n3 = Convert.ToDouble(Console.ReadLine());
            double media = (n1 * 0.25) + (n2 * 0.25) + (n3 * 0.5);
            if (media >= 9)
            {
                Console.WriteLine("Conceito A");
            }
            else if (media >= 7.5 && media < 9)
            {
                Console.WriteLine("Conceito B");
            }
            else if (media >= 6 && media < 7.5)
            {
                Console.WriteLine("Conceito C");
            }
            else
            {
                Console.WriteLine("Conceito D");
            }

            Console.ReadKey();

        }
    }
}

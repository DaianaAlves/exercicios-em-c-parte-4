using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor das vendas:");
            double vendas = Convert.ToDouble(Console.ReadLine());
            if (vendas<1000)
            {
                Console.WriteLine("Sem prêmio");

            }
            else if((vendas >= 1000) && (vendas <3000))
            {
                Console.WriteLine(" Seu prêmio é R$150,00");

            }
            else
            {
                Console.WriteLine("Seu prêmio é R$300,00");
            }
            Console.ReadKey();
        }
    }
}

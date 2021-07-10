using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalnum;
            Console.Write("Produto:");
            String produto = Console.ReadLine();
            Console.Write("quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço unitario:");
            double preco = Convert.ToDouble(Console.ReadLine());
            double total = quantidade * preco;
            Console.WriteLine("Total: " + total);
            if(quantidade <=5)
            {
                Console.WriteLine("Desconto de 2%");
                double desconto = total * 0.02;
            }
            else if(quantidade > 5 && quantidade <=10)
            {
                Console.WriteLine("dESCONTO DE 3");
                double desconto = total * 0.03;
            }
            else
            {
                Console.WriteLine("Desconto de 5%");
                double Desconto = total * 0.05;
                totoalnum = total - Desconto;

            }
            Console.WriteLine("Valor a pagar:" + totalnum);
            Console.ReadKey();
        }
    }
}

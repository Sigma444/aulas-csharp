using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condiçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else
            {
                Console.WriteLine("É menor de idade");
            }
            
        }
    }
}

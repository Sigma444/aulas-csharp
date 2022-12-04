using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Digite a idade do aluno para saber se é um bebê,uma criança,um adolescente ou adulto
            Console.WriteLine("Digite sua idade");
         //Converte a variável de string para Int, e lê a linha escrita
            int idade = int.Parse(Console.ReadLine());
            //Verifica a idade e define a condição do aluno de acordo com a mesma
            if (idade < 2)

                // Se o aluno obter menos de dois anos, significa que ele é um bebê
                Console.WriteLine("É um bebê");

            else if (idade < 10)
                //Se o aluno obtiver menos de dez anos, significa que ele é uma criança
                Console.WriteLine("O aluno é uma criança");

            else if (idade < 18)
                //Se o aluno obtiver menos de 18 anos, significa que ele é um adolescente
                Console.WriteLine("O aluno é um adolescente");

            else if (idade < 60)
                //Se o aluno obtiver menos de 60 anos, significa que ele é um adulto
                Console.WriteLine("O aluno é um adulto");

            //Fim!
            Console.ReadKey();




                





            


         
        }
    }
}

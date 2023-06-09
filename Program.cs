using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadadeC_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string prodruto1;
            int quantidade=75;
            string prodruto2;
            int quant2 = 23;
            int total = quantidade + quant2;

            Console.WriteLine(" \n\n Bem-Vindo ao sistema de estoque do Cadu \n\n");
            Console.WriteLine($"Digite o nome do Funcionario responsável:");
                nome = Console.ReadLine();

            Console.WriteLine($"O CADASTRO DE ESTOQUE FOI FEITO NO NOME DE {nome}");
            Console.WriteLine("\n\n -- CADASTRO DE PRODUTOS \n\n ");
            Console.WriteLine($" \n Digite o nome do produto 1: \n");
               prodruto1 = Console.ReadLine();

            Console.WriteLine("Digite a quantidade em estoque da Calça:");
               int quantidadade = Int32.Parse( Console.ReadLine());

            Console.WriteLine(" \n Digite o nome do produto 2: \n ");
               prodruto2 = Console.ReadLine();

            Console.WriteLine(" \n Digite a quantidade em estoque de Perfume: \n ");
               int quanti2 =  Int32.Parse( Console.ReadLine());

            Console.WriteLine(" \n\n\n -- OS PRODUTOS FORAM CADASTRADOS COM SUCESSO! \n\n\n");
            Console.WriteLine($" \n--- LISTA DE PRODUTOS CADASTRADOS POR {nome} \n ");
            Console.WriteLine($"{prodruto1} contém {quantidade=75} intens em estoque ");
            Console.WriteLine($"{prodruto2} contém {quant2} em estoque");
            Console.WriteLine($" \n\n Total de itens em estoque {total} \n\n ");

            






            




                

            
            
            
            
            
            
            
            
            Console.ReadKey();

        }
    }
}

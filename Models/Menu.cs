using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Menu
    {
        public void menu()
        {
            int opcao = 0;
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro de cliente");
                        break;
                    case 2:
                        Console.WriteLine("Busca de cliente");
                        break;
                    case 3:
                        Console.WriteLine("Apagar cliente");
                        break;
                    case 4:
                        Console.WriteLine("Sair");
                        Environment.Exit(0);//encerra o programa, não executa mais nada
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            Console.WriteLine("Você encerrou o programa.");

            
        }
        
    }
}
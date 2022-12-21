using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class Contadores
    {
        public void TaboadaFor()
        {
            Console.WriteLine("informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        public void TaboadaWhile()
        {
            Console.WriteLine("informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador ++;

                if(contador == 5)
                {
                    break;
                }
            }
        }

        public void Soma()
        {
            int somar = 0, numero = 0;

            do
            {
                Console.WriteLine("informe um número (0 para sair): ");
                numero = Convert.ToInt32(Console.ReadLine());

                somar += numero;

            } while(numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: {somar}");
            
        }
    }
}
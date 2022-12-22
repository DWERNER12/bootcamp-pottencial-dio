using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class ExemploArray
    {
        public void testeArray()
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            int[] arryInteiroDobrado = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arryInteiroDobrado, arrayInteiros.Length);

            /*Forma de redimencionar um array, criando uma copia do arry antigo em um novo arry.
            não é recomendado fazer dessa forma
            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);*/


            Console.WriteLine("Percorrendo o array com FOR");
            for(int contador = 0; contador<arrayInteiros.Length; contador++ ){
                Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");
            }

            Console.WriteLine("Percorrendo o array com FOREACH");
            int contadorForeach = 0;
            foreach (var valor in arrayInteiros)
            {
                Console.WriteLine($"Posição Nº{contadorForeach} - {valor}");
                contadorForeach++;
            }
            Console.WriteLine("Dobrando o arry");
            int contadorForeach2 = 0;
            foreach (var valor2 in arryInteiroDobrado)
            {
                Console.WriteLine($"Posição Nº{contadorForeach2} - {valor2}");
                contadorForeach2++;
            }


        }
        
    }
}
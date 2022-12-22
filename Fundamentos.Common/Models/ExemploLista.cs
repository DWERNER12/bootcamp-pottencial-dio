using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class ExemploLista
    {
        public void lista()
        {
            List<string> listaString = new List<string>();

            listaString.Add("SP");
            listaString.Add("BA");
            listaString.Add("MG");
            listaString.Add("RJ");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

            listaString.Add("SC");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

            listaString.Remove("MG");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");





            // Console.WriteLine("Percorrendo lista com FOR");
            // for(int contador = 0; contador<listaString.Count; contador++)
            // {
            //     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
            // }

            // Console.WriteLine("Percorrendo uma lista com FOREACH");
            // int contadorForeach = 0;
            // foreach (string item in listaString)
            // {
            //     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
            //     contadorForeach++;
            // }
        }
    }
}
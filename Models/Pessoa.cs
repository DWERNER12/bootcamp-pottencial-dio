using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//caminho da classe
namespace fundamentos.Models
{
    public class Pessoa
    {
        //Propriedades (nome,idade)
        //get = pega o valor da propriedade 
        //set = atribui valor a propriedade 
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //metodo ou função "apresentar"
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
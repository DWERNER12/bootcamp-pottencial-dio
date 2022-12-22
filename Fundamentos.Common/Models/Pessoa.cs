using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//caminho da classe
namespace Fundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa
    {
        //Propriedades (nome,idade)
        //get = pega o valor da propriedade 
        //set = atribui valor a propriedade 
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //metodo ou função "apresentar"
        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
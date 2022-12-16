using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Condicionais
    {
        public void OperadorOr()
        {
            Console.WriteLine("Quantos anos você tem?");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Possue autorização dos pais?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int autorizacaoDosPais = Convert.ToInt32(Console.ReadLine());

            if(idade >= 18 || autorizacaoDosPais == 1)
            {
                Console.WriteLine("Entrada autorizada");
            }
            else
            {
                Console.WriteLine("Entrada não permitida");
            }

        }

        public void OperadorAnd()
        {
            Console.WriteLine("Informe a quantidade de horas que o aluno(a) esteve presente durante o ano?");
            int cargaHoraria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a primeira nota do aluno:");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota do aluno:");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine()); 
            decimal media = (primeiraNota + segundaNota)/2;
            
            if(cargaHoraria >= 600 && media >= 7)
            {
                Console.WriteLine($"Presença {cargaHoraria}hs. (Minima 600hs)");
                Console.WriteLine($"Média {media}. (Minima 7)");
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine($"Presença {cargaHoraria}hs. (Minima 600hs)");
                Console.WriteLine($"Média {media}. (Minima 7)");
                Console.WriteLine("Reprovado");
            }
        }

        public void OperadorNot()
        {
            bool choveu = true;
            bool estaTarde = true;
            if(!choveu && !estaTarde)
            {
                Console.WriteLine("Vou pedalar!");
            }
            else
            {
                Console.WriteLine("Vou pedalar outro dia!");
            }
        }
    }
}
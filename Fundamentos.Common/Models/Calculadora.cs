using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números.
        /// </summary>
        /// <param name="x">Primeiro número inteiro da soma.</param>
        /// <param name="y">Segundo número inteiro da soma.</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Realiza uma subtração de dois números.
        /// </summary>
        /// <param name="x">Primeiro número inteiro da subtração.</param>
        /// <param name="y">Segundo número inteiro da subtração.</param>
        /// <returns>Retorna dois números inteiros.</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }
        public void Mutiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno do {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno do {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"Tangente do {angulo}° = {Math.Round(tan, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    }
}
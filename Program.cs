using fundamentos.Models;

Pessoa pessoa = new Pessoa();
Console.WriteLine("Informe o nome:");
pessoa.Nome = Console.ReadLine();
Console.WriteLine("Informe a idade:");
pessoa.Idade = Convert.ToInt16(Console.ReadLine());
pessoa.Apresentar();
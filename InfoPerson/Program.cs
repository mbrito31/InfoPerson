using System;
using System.IO;
using System.Text.Json;



public class Pessoa
{
    public string? Nome { get; set; }
    public int? Idade { get; set; }
    public string? Email { get; set; }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o e-mail: ");
        pessoa.Email = Console.ReadLine();

        string json = JsonSerializer.Serialize(pessoa, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("pessoa.Json", json);

        Console.WriteLine("Informações salvas em pessoa.json");
    }

    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        while (true)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o e-mail: ");
            pessoa.Email = Console.ReadLine();

            pessoas.Add(pessoa);

            Console.WriteLine("Deseja adicionar outra pessoa? (s/n): ");
            if (!Console.ReadLine().Equals("s", StringComparison.CurrentCultureIgnoreCase))
            {
                break;
            }
        }

        string json = JsonSerializer.Serialize(pessoas, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("pessoas.json", json);

        Console.WriteLine("Informações salvas em pessoas.json");
    }
}
using SeralizarListaDePessoas;
using System.Text.Json;
using System.Linq;

Pessoas pessoas = new Pessoas("Lista");

Usuario hiago = new Usuario("Hiago", 21);
Usuario dede = new ("Ricardo", 20);
Usuario pedro = new ("Pedro", 25);
Usuario jurema = new ("Jurema", 28);
Usuario yuri = new ("Yuri", 15);

pessoas.AdicionarNaLista(hiago);
pessoas.AdicionarNaLista(dede);
pessoas.AdicionarNaLista(pedro);
pessoas.AdicionarNaLista(jurema);
pessoas.AdicionarNaLista(yuri);

//pessoas.GerarListaJson();

//pessoas.ExibirPessoasDaLista();
Console.WriteLine();
//Console.WriteLine("Digite uma idade, para filtrar pessoas correspondente a essa idade: ");
//int idadeDosUsuarios = Convert.ToInt32(Console.ReadLine()!);


string path = @"C:\Projetos\c#\SeralizarListaDePessoas\idade.json";
string resposta = File.ReadAllText(path);


//var Teste = JsonSerializer.Deserialize<Usuario>(resposta)!;
//Console.WriteLine(resposta);

var consulta = resposta.Select(Usuario => hiago.Idade).Where(Usuario => pessoas.Idade <= 20).ToList()!;
foreach (var usuarios in consulta) 
{
    Console.WriteLine($"- {usuarios}");
}


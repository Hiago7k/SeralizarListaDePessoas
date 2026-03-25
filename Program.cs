using SeralizarListaDePessoas;
using System.Text.Json;

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

pessoas.ExibirPessoasDaLista();

//string path = @"C:\Projetos\c#\SeralizarListaDePessoas\pessoas da lista - Lista.json";
//string resposta = File.ReadAllText(path);

//var Teste = JsonSerializer.Deserialize<Usuario>(resposta)!;
//Console.WriteLine(resposta);

Console.WriteLine("Digite uma idade, para filtrar pessoas correspondente a essa idade: ");
int idadeDosUsuarios = Convert.ToInt32(Console.ReadLine()!);


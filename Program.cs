using SeralizarListaDePessoas;
using System.Text.Json;

Pessoas pessoas = new Pessoas("Lista");

Usuario hiago = new Usuario("Hiago");
Usuario dede = new ("Ricardo");
Usuario pedro = new ("Pedro");
Usuario jurema = new ("Jurema");
Usuario yuri = new ("Yuri");

pessoas.AdicionarNaLista(hiago);
pessoas.AdicionarNaLista(dede);
pessoas.AdicionarNaLista(pedro);
pessoas.AdicionarNaLista(jurema);
pessoas.AdicionarNaLista(yuri);
//pessoas.GerarListaJson();

//pessoas.ExibirPessoasDaLista();

string path = @"C:\Projetos\c#\SeralizarListaDePessoas\pessoas da lista - Lista.json";
string resposta = File.ReadAllText(path);

var Teste = JsonSerializer.Deserialize<Usuario>(resposta)!;
Console.WriteLine(resposta);




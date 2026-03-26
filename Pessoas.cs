using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeralizarListaDePessoas;

internal class Pessoas
{
    List<Usuario> ListaDePessoas = new List<Usuario>();

    public Pessoas(string nome)
    {
        Nome = nome;
        ListaDePessoas = new List<Usuario>();
    }

    public string Nome { get;  }
    public int Idade { get;  }


    public void AdicionarNaLista(Usuario usuarios) 
    {
        ListaDePessoas.Add(usuarios);
    }


    public void ExibirPessoasDaLista() 
    {
        foreach (var pessoas in ListaDePessoas)
        {
            Console.WriteLine($"- {pessoas.NomeDaPessoa}  {pessoas.Idade}");
        }
    }


    public  void GerarListaJson() 
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            pessoas = ListaDePessoas
        });
        string nomeDoArquivo = $"pessoas da lista - {Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
    }

}

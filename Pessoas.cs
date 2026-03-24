using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


    public void AdicionarNaLista(Usuario usuarios) 
    {
        ListaDePessoas.Add(usuarios);
    }


    public void ExibirPessoasDaLista() 
    {
        foreach (var pessoas in ListaDePessoas)
        {
            Console.WriteLine($"- {pessoas.NomeDaPessoa}");
        }
    }
}

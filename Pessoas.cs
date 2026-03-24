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
        ListaDePessoas = new List<Usuario>();
        Nome = nome;
    }

    public string Nome { get;  }
}

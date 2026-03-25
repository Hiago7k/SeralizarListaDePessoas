using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeralizarListaDePessoas;

internal class Usuario
{
    public Usuario(string nomeDaPessoa, int idade)
    {
        NomeDaPessoa = nomeDaPessoa;
        Idade = idade;
    }

    public string NomeDaPessoa { get; set; }
    public int Idade { get; set; }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeralizarListaDePessoas;

internal class Usuario
{
    public Usuario(string nomeDaPessoa)
    {
        NomeDaPessoa = nomeDaPessoa;
    }

    public string NomeDaPessoa { get; set; }



}

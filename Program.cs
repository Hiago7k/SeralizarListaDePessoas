using SeralizarListaDePessoas;

Pessoas pessoas = new Pessoas("Lista");

Usuario hiago = new Usuario("Hiago");
Usuario dede = new Usuario("Ricardo");
Usuario pedro = new Usuario("Pedro");
Usuario jurema = new Usuario("Jurema");
Usuario yuri = new Usuario("Yuri");

pessoas.AdicionarNaLista(hiago);
pessoas.AdicionarNaLista(dede);
pessoas.AdicionarNaLista(pedro);
pessoas.AdicionarNaLista(jurema);
pessoas.AdicionarNaLista(yuri);

pessoas.ExibirPessoasDaLista();
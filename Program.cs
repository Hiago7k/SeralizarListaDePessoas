using SeralizarListaDePessoas;

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

pessoas.ExibirPessoasDaLista();


pessoas.GerarListaJson();
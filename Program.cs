Episodio ep1 = new(1, "Técnica de facilitação", 45);
ep1.AdicionarConvidados("Marcelo");
ep1.AdicionarConvidados("Maria");


Podcast podcast = new("Na bola do zoio", "Pedro");
podcast.AdicionarEpisodio(ep1);
podcast.ExibirDetalhes();
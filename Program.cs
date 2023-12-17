Episodio ep1 = new Episodio(1, "Tecnica de facilitação", 45 );
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");


Episodio ep2 = new Episodio(2, "Tecnica de aprensizado", 45 );
ep2.AdicionarConvidado("Fernando");
ep2.AdicionarConvidado("Marcos");
ep2.AdicionarConvidado("Flavia");

Podcast podcast = new Podcast("Podcast especial", "Daniel");

podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExbirDetalhes();
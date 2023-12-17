class Podcast 
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome {get; }
    public string Host {get; }
    public int TotalEpisodios => episodios.Count();

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExbirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentando por {Host} \n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste episodio possui {TotalEpisodios} episodios");
    }
}
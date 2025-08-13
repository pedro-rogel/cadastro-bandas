class Podcast
{
    private List<Episodio> episodios = [];
    public string? Nome { get; set; }
    public string? Host { get; set; }
    public int TotalEp => episodios.Count;
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por {Host}");
        foreach (Episodio ep in episodios.OrderBy(v => v.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"Total de ep: {TotalEp}");
    }

}
class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = [];
    public string? Nome { get;}
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
    public void AdicionarMusicaNoAlbum(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        musicas.ForEach(musica => Console.WriteLine($"Musicas do Album: {musica.Nome}"));
        Console.WriteLine($"Para ouvir esse album inteiro, você precisará de {DuracaoTotal} segundos");
    }
 }
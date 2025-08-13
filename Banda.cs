class Banda
{

    public Banda(string artista)
    {
        Nome = artista;
    }
    private List<Album> albums = [];
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        albums.ForEach(item => Console.WriteLine($"Album {item.Nome} duração de {item.DuracaoTotal} segundos"));
    }
}

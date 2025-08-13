using System;
class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string? Nome { get; }
    public Banda? Artista{ get;}
    public int Duracao { get; set; }
    public bool Disponivel{ get; set; }
    public string? DescricaoResumida => $"A musica {Nome} pertence a {Artista}";

    public Genero? Genero { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artisita: {Artista?.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genêro: {Genero?.Tipo}");
        if (Disponivel) Console.WriteLine("Disponivel no plano.");
        else Console.WriteLine("Adquira o plano Plus+.");
    }


}
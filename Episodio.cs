class Episodio
{
    private List<string> convidados = [];
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }
    public int Duracao { get; }
    public int Ordem { get; }
    public string? Resumo => $"{Ordem}.  {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public string? Titulo { get; set; }

    public void AdicionarConvidados(string condidado)
    {
        convidados.Add(condidado);
    }

}
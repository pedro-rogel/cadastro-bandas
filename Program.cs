string mensagemDeBoasVindas = "Boas vindas ao screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>> { { "Link Park", new List<int> { 10, 8, 5 }}, {"O Rappa", new List<int> {}} };

void ExibirMenssagem(string msg)
{
    List<char> listaCarcter = [];
    int i = 0;
    while (i < msg.Length)
    {
        listaCarcter.Add('*');
        i++;
    }

    Console.WriteLine(string.Join("", listaCarcter));
    Console.WriteLine(msg);
    Console.WriteLine(string.Join("", listaCarcter));
}

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    ExibirMenssagem(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    Console.WriteLine("Digite 1 para registrar banda");
    Console.WriteLine("Digite 2 para listar bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite ESC para sair");
    Console.Write("\nDigite sua opção: ");

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);


    if (keyInfo.Key == ConsoleKey.Escape)
    {
        Console.WriteLine("\nSaindo...");
        Environment.Exit(0); // Encerra o programa
    }
    else if (char.IsDigit(keyInfo.KeyChar))
    {
        int opcaoEscolhidaNumerica = int.Parse(keyInfo.KeyChar.ToString());

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}");
                RegistrarBandas();
                break;
            case 2:
                Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}");
                ListarBandas();
                break;
            case 3:
                Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}");
                AvaliarBanda();
                break;
            case 4:
                Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}");
                ExibirNotas();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("\nTecla inválida! Pressione um número ou ESC.");
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirMenssagem("Registrar Banda");
    Console.Write("Digite o nome da banda: ");
    string banda = Console.ReadLine()!;
    if (banda is not string) return;
    bandasRegistradas.Add(banda, new List<int>());
    Console.WriteLine("Banda Registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirMenssagem("Bandas Cadastradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Aperte Enter para voltar ao menu!");
    while (true)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            ExibirMenu();
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Comando errado! Tente novamente");
            continue;
        }
    }



}

void AvaliarBanda()
{
    Console.Clear();
    ExibirMenssagem("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(1500);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void ExibirNotas()
{
    Console.Clear();
    ExibirMenssagem("Média das bandas");
    Console.Write("Digite o nome da banda que deseja ver a nota: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        double mediaDaBanda = notasDaBanda.Average();
        Console.WriteLine($"As notas da banda {nomeDaBanda} são: {string.Join(", ", notasDaBanda)}");
        Console.WriteLine($"A média de notas da banda {nomeDaBanda} é {mediaDaBanda:F2}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }

}


ExibirLogo();
ExibirMenu();




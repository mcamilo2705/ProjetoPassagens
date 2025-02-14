
using System.Reflection.Metadata.Ecma335;

string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] datas = new string[2];

Console.WriteLine("---------------------------");
Console.WriteLine("Sistema de passagens aereas");
Console.WriteLine("---------------------------");

EfetuarLogin();

int opcao;

do
{
   
    Console.WriteLine("Menu Incial");
    Console.WriteLine("Selecione uma opcao: ");
    Console.WriteLine("[1] - Cadastrar passagem ");
    Console.WriteLine("[2] - Listar as passagens ");
    Console.WriteLine("[0] - Sair do Sistema ");

    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            CadastrarPassagens();
            Console.Clear();
            break;
        case 2:
            ListarPassagens();
            break;
        case 0:
            Sair();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opcao invalida! ");
            break;
    }

} while (opcao != 0);

    static void EfetuarLogin()
{

    string senhaRecebida;

    //faca enquanto
    do
    {
        Console.Write("Digite a senha: ");
        senhaRecebida = Console.ReadLine();
    } while (senhaRecebida != "123456");


}

void CadastrarPassagens()
{
    Console.WriteLine("Iniciando cadastro de passagem...");
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.Write($"Digite o nome do {i + 1} passageiro: ");
        nomes[i] = Console.ReadLine();

        Console.Write($"Digite a origem do {i + 1} passageiro: ");
        origens[i] = Console.ReadLine();

        Console.Write($"Digite o destino do {i + 1} passageiro: ");
        destinos[i] = Console.ReadLine();

        Console.Write($"Digite a data do {i + 1} passageiro: ");
        datas[i] = Console.ReadLine();
    }
    Console.WriteLine("Passagens cadastradas com sucesso! ");
}

void ListarPassagens()
{
    Console.Write("Lista de passagens ");
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Passagem aere {i + 1}");
        Console.WriteLine($"Nome: {nomes[i]}");
        Console.WriteLine($"Origem: {origens[i]}");
        Console.WriteLine($"Destino: {destinos[i]}");
        Console.WriteLine($"Data: {datas[i]}");
    }
}

void Sair()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Finalizando sistema...");
}

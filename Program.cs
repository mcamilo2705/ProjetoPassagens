
string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] data = new string[2];

Console.WriteLine("---------------------------");
Console.WriteLine("Sistema de passagens aereas");
Console.WriteLine("---------------------------");

EfetuarLogin();


Console.WriteLine("Menu Incial");
Console.WriteLine("Selecione uma opcao: ");
Console.WriteLine("[1] - Cadastrar passagem "); 
Console.WriteLine("[2] - Listar as passagens "); 
Console.WriteLine("[0] - Sair do Sistema "); 

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
   
}



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


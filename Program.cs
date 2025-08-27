using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

decimal precoInicial = ObterPreco("Digite o preço inicial: ");
decimal precoPorHora = ObterPreco("Agora digite o preço por hora: ");

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

decimal ObterPreco(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        if (decimal.TryParse(Console.ReadLine(), out decimal preco))
        {
            return preco;
        }
        Console.WriteLine("Valor inválido. Por favor, digite um número.");
    }
}


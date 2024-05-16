using ConsoleApp6.Entities;
using ConsoleApp6.Enum;
using ConsoleApp6.Interfaces;
using ConsoleApp6.Services;
using System.IO;

bool iniciar = true;


List<IProduto> itens = new List<IProduto>();
Compra compra = new Compra();

Console.WriteLine("PRODUTOS DISPONÍVEL:");
Console.WriteLine("\nArroz");
Console.WriteLine("Chocolate");
Console.WriteLine("Chuveiro");
Console.WriteLine("Leite");
Console.WriteLine("Papel");
Console.WriteLine("Pasta de Dente");
Console.WriteLine("Refrigerante \n");



    while (iniciar)
    {

    try
    {

        Console.Write("Digite o nome do produto: ");
        string name = Console.ReadLine();
        Console.Write("Quantidade do Produto: ");
        int qt = int.Parse(Console.ReadLine());
        qt = (qt <= 0) ? qt = 1 : qt;
        Console.Write("Qual a Qualidade? (Ruim/Bom/Muito_Bom/Excelente) ");
        Tipo tipo = Enum.Parse<Tipo>(Console.ReadLine());


        switch (name.ToLower())
        {
            case "papel":
                Papel _papel = new Papel(name, tipo, qt);
                itens.Add(_papel);
                compra.Somando(qt, _papel);
                break;

            case "arroz":
                Arroz _arroz = new Arroz(name, tipo, qt);
                itens.Add(_arroz);
                compra.Somando(qt, _arroz);
                break;
            case "chocolate":
                Chocolate _chocolate = new Chocolate(name, tipo, qt);
                itens.Add(_chocolate);
                compra.Somando(qt, _chocolate);
                break;
            case "chuveiro":
                Chuveiro _chuveiro = new Chuveiro(name, tipo, qt);
                itens.Add(_chuveiro);
                compra.Somando(qt, _chuveiro);
                break;
            case "leite":
                Leite _leite = new Leite(name, tipo, qt);
                itens.Add(_leite);
                compra.Somando(qt, _leite);
                break;
            case "pasta de dente":
                PastaDeDente _pastaDeDente = new PastaDeDente(name, tipo, qt);
                itens.Add(_pastaDeDente);
                compra.Somando(qt, _pastaDeDente);
                break;
            case "refrigerante":
                Refrigerante _refrigerante = new Refrigerante(name, tipo, qt);
                itens.Add(_refrigerante);
                compra.Somando(qt, _refrigerante);
                break;
            default:
                Console.WriteLine("Produto não Localizado! Tente Novamente \n");
                break;
        }

        Console.Write("Deseja continuar comprando? (sim/não) ");
        string continuarComprando = Console.ReadLine();
        Console.WriteLine();
        if (continuarComprando == "não")
        {
            iniciar = false;
        }

    }
    catch (ArgumentException e)
    {
        Console.WriteLine("Valor inesperado! Tente Novamente... (" + e.Message + ") \n");
    }
}

    string path = @"C:\Users\Principal\Documents\text.txt";
    using (StreamWriter rs = new StreamWriter(path, true))
    {
        foreach (IProduto item in itens)
        {
            rs.WriteLine(item);
        }
    }
foreach(IProduto produto in itens)
{
    Console.WriteLine("--- " + produto + " ----");
}


var filtro = itens.Where(x => x.Valor >= 50).Select(x => x);
using (StreamWriter pt = new StreamWriter(path, true))
{
    Console.WriteLine("\n Itens com o Valor Superior a R$ 50,00!");

    p
    foreach (IProduto produto in filtro)
    {
        using (StreamWriter rs = new StreamWriter(path, true))
        {
            rs.WriteLine(produto);
        }
    }
}




using System;
using System.IO;

string nome = string.Empty;
bool premiun = false;
int dia = -1;
// TODO

//Vou completar esta bela obra semana que vem,
//se não for demitido né vai que kkkk
//caracteres úteis: ─│┌┐└┘├┤┬┴┼
Console.WriteLine("┌───┐ ┌───┐");
Console.WriteLine("│┌─┐│ │┌─┐│");
Console.WriteLine("│└─┘│ ││ ││");
Console.WriteLine("│ ┌─┘ ││ ││");
Console.WriteLine("│ └─┐ ││ ││");
Console.WriteLine("│┌─┐│ ││ ││");
Console.WriteLine("│└─┘│ │└─┘│");
Console.WriteLine("└───┘ └───┘");
Console.WriteLine("\t\tTecnologia para a vida");
Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla para começar...");
Console.ReadKey(true);

while (true)
{
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("1 - Cadastrar Novo cliente");
    Console.WriteLine("2 - Ler dados do cliente");
    Console.WriteLine("3 - Cadastrar Novo produto");
    Console.WriteLine("4 - Ler dados do produto");
    Console.WriteLine("5 - Sair");
    int id = int.Parse(Console.ReadLine());
    switch(id)
    {
        case 1:
            Console.Write("Digite o nome do Cliente:");
            nome = Console.ReadLine();

            Console.Write("Digite se o cliente é premium:");
            bool premium = bool.Parse(Console.ReadLine());

            Console.Write("Digite o dia que o cliente nasceu:");
            int diaa = int.Parse(Console.ReadLine());

            Console.Write("Digite o mes que o cliente nasceu:");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite se o ano que o cliente nasceu:");
            int ano = int.Parse(Console.ReadLine());


            Cliente cliente = new Cliente(nome, premium, diaa, mes, ano);
            cliente.Save();
            break;
        
        case 2:
            Console.Write("Digite o nome do Cliente:");
            nome = Console.ReadLine();
            Console.WriteLine($"O nome do cliente é: {nome}\nPremium: {Cliente.Load(nome).Premium} \nData de Nascimento: {Cliente.Load(nome).DiaNascimento}/{Cliente.Load(nome).MesNascimento}/{Cliente.Load(nome).AnoNascimento}");
            Thread.Sleep(5000);
            break;

        case 3:
            Console.Write("Digite o nome do Produto:");
            nome = Console.ReadLine();

            Console.Write("Digite se o preço do produto:");
            int preco = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco);
            produto.Save();
            break;

        case 4:

            Console.Write("Digite o nome do produto:");
            nome = Console.ReadLine();
            Console.WriteLine($"O nome do produto é: {nome}\nPreço: {Produto.Load(nome).Preco}");
            Thread.Sleep(5000);
            break;

        case 5:
            Environment.Exit(0);
            break;
    }
}

public class Cliente
{
    public Cliente(string nome, bool premium, int dia, int mes, int ano)
    {
        this.Nome = nome;
        this.Premium = premium;
        this.DiaNascimento = dia;
        this.MesNascimento = mes;
        this.AnoNascimento = ano;
    }

    public string Nome { get; set; }
    public bool Premium { get; set; }
    public int DiaNascimento { get; set; }
    public int MesNascimento { get; set; }
    public int AnoNascimento { get; set; }

    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Nome + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Premium);
        writer.WriteLine(this.DiaNascimento);
        writer.WriteLine(this.MesNascimento);
        writer.WriteLine(this.AnoNascimento);

        writer.Close();
    }

    public static Cliente Load(string nome)
    {
        nome = nome;
        StreamReader reader = new StreamReader(nome + ".txt");

        string random = reader.ReadLine();

        bool premium = bool.Parse(reader.ReadLine());

        int dia = int.Parse(reader.ReadLine());

        int mes = int.Parse(reader.ReadLine());

        int ano = int.Parse(reader.ReadLine());

        
        Cliente cliente = new Cliente(nome, premium, dia, mes, ano);
        return cliente;
    }
}

public class Produto
{
    public Produto(string nome, int preco)
    {
        this.Nome = nome;
        this.Preco = preco;
    }

    public string Nome { get; set; }
    public int Preco { get; set; }

    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Nome + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Preco);

        writer.Close();
    }

    public static Produto Load(string a)
    {
        string produtoo = a;
        StreamReader reader = new StreamReader(produtoo + ".txt");


        string random = reader.ReadLine();       
        int preco = int.Parse(reader.ReadLine());


        Produto produto = new Produto(produtoo, preco);
        return produto;
    }
}
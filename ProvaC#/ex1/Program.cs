List<int> notas = new List<int>(){};

int i = 0;
while(true)
{
    i++;
    Console.WriteLine($"Digite a {i}º nota: ");
    int nota = int.Parse(Console.ReadLine());
    notas.Add(nota);


    Console.WriteLine($"Deseja adicionar mais uma nota? Se não, digite 0!");
    int escolha = int.Parse(Console.ReadLine());
    if (escolha == 0)
        break;

}

List<int> MediaEspecial(List<int> lista)
{
    lista.RemoveAt(0);
    lista.RemoveAt(lista.Count()-1);
    return lista;
}

int qtt = 0;
int soma = 0;
foreach (var item in MediaEspecial(notas))
{
    soma += item;
    qtt++;
}

Console.WriteLine($"A media das notas foi: {soma/qtt}");

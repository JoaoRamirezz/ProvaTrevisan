using System.Linq;
using System.Collections.Generic;

App.Run();

public class Pesquisador
{
    public List<string> Search(
        IEnumerable<Colaborador> collab,
        string parametro)
    {
        List<string> colaboradores = new List<string>();
        var data = parametro.Split(' ');
        var it = collab.GetEnumerator();
        while(it.MoveNext())
            string nome = it.Current.ToString();
            foreach (var item in data)
            {
                if (it.Current.Name.Contains(item))
                    colaboradores.Add(it.Current);
            }
        return colaboradores;
    }
}

public class Colaborador
{
    public Colaborador(string nome, string cargo, string setor, string edv)
    {
        this.Nome = nome;
        this.Cargo = cargo;
        this.Setor = setor;
        this.Edv = edv;
    }

    public string Nome { get; set; }
    public string Cargo { get; set; }
    public string Setor { get; set; }
    public string Edv { get; set; }
}
namespace CSharpCollections;

public class AulasListas
{
    public static void main()
    {
        var alunos = new List<string>() { "Cleyson", "Elton", "Wesley", "Ana", "Ariel" };
        imprimir(alunos);
        Console.WriteLine(alunos.Count);
        Console.WriteLine(alunos.Capacity);

        // alunos.Clear();
        // imprimir(alunos);
        // Console.WriteLine(alunos.Count);
        // Console.WriteLine(alunos.Capacity);

        Console.WriteLine(alunos.Contains("Sara"));

        Console.WriteLine(alunos.Remove("Elton"));
        imprimir(alunos);
        Console.WriteLine(alunos.Remove("Elton"));

        Console.WriteLine(alunos.First());
        Console.WriteLine(alunos.Last());
    }

    private static void imprimir(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
namespace CShapCollections;

public class AulaArrays
{
    public static void main()
    {
        var alunos = new string[] { "Cleyson", "Elton", "Ana", "Gustavo", "Sara", "Wesley" };


        // alunos[0] = "Cleyson";
        // alunos[1] = "Elton";
        // alunos[2] = "Ana";
        // alunos[3] = "Gustavo";
        // alunos[4] = "Sara";
        Console.WriteLine(alunos.Length);
    }

    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
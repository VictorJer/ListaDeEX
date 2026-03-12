internal class Program
{
    private static void Main(string[] args)
    {
        double[] nota = new double[2];
        double[] peso = new double[2];


        for (int j = 0; j < 2; j++)
        {
            System.Console.WriteLine($"qual a nota {j + 1} do aluno: ");
            nota[j] = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("qual o peso dela: ");
            peso[j] = Convert.ToDouble(Console.ReadLine());
        }

        double media = (nota[0] * peso[0] + (nota[1] * peso[1])) / (peso[0] + peso[1]);

        System.Console.WriteLine($"a media ponderada é: {media}");

        Console.ReadLine();
    }
}
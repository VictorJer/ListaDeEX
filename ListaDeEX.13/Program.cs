using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        System.Console.Write("Digite o valor A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("DIgite o valor B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("DIgite o valor C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        double soma = A + B;

        if (soma < C)
        {
            System.Console.WriteLine("A soma de A + B é menor que C");
            Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("A soma de A + B é maior que C");
        }
    }
}
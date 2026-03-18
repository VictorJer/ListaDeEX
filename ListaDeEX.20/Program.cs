internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número de 1 a 10: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1 || N > 10)
        {
            Console.WriteLine("Número inválido!");
            return;
        }

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {N} = {i * N}");
        }
    }
}
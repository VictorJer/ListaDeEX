internal class Program
{
    private static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 1; i <= 500; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine($"A soma dos números ímpares de 1 a 500 é: {soma}");
    }
}
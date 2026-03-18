internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o numero A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o numero B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int C = 0;

        if (a == b)
        {
            C = a + b;
        }
        else
        {
            C = a * b;
        }

        Console.WriteLine($"O valor de C é: {C}");
    }
}
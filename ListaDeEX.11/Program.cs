internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        System.Console.Write("qual o seu nome: ");
        string? nome = Console.ReadLine();

        System.Console.Write($"quantos anos você tem {nome}: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        int dias = idade * 365;

        System.Console.WriteLine($"{nome} você ja viveu {dias} dias!");
        Console.ReadLine();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        System.Console.Write("quantidade de pães vendidos: ");
        int paom = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("quantidade de broas vendidas: ");
        int broa = Convert.ToInt32(Console.ReadLine());

        double total = (paom * 0.12) + (broa * 1.50);

        double poupa = total * 0.1;

        System.Console.WriteLine($"quantidete bruta {total}R$ você deve guardar na poupança {poupa}R$");
    }
}
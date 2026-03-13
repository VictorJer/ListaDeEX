internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Digite a largura do terreno: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Digite o comprimento do terreno: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        double area = largura * comprimento;

        System.Console.WriteLine($"a area do terreno é {area}m³");
        Console.ReadLine();
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o raio do cilindro: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do cilindro: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double areaBase = 3.14 * raio * raio;

        double volume = areaBase * altura;

        System.Console.WriteLine($"o volume do ciclindro é {volume.ToString("F2")}");
        Console.ReadLine();
    }
}
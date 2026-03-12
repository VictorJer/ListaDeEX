internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a temperatura em Celsius: ");
        double Celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (Celsius * 1.8) + 32;

        System.Console.WriteLine($"A converção de celsius para fahrenheit é: {fahrenheit}");
        
        Console.ReadLine();
    }
}
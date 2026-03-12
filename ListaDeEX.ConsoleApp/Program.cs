// Crie um programa para calcular o volume de uma caixa retangular

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o comprimento da caixa: ");
        decimal comprimento = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a largura da caixa: ");
        decimal largura = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a altura: ");
        decimal altura = Convert.ToDecimal(Console.ReadLine());

        decimal volume = comprimento * largura * altura;

        System.Console.WriteLine("o volume da caixa é: " + volume);
        Console.ReadLine();
    }
}
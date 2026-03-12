internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a quilometragem inicial do veiculo: ");
        decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a quilometragem final do veiculo: ");
        decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a quantidade de combustivel consumida (litros): ");
        decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

        decimal distanciaPercorrida = kmFinal - kmInicial;

        decimal consumoLitrosPorKm = distanciaPercorrida / combustivelConsumido;

        System.Console.WriteLine($"O consumo de combustivel durante o percurso foi de : {consumoLitrosPorKm} km");

        Console.ReadLine();
        
    }
}
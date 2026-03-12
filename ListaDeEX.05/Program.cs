internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Digite o salario base do colaborador: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Digite o percentual sobre o total de vendas: ");
        double percentual = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Digite o total de vendas do colaborador: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        double percentualADDsalario = totalVendas / percentual;

        double salarioFinal = percentualADDsalario + salarioBase;

        System.Console.WriteLine($"o salario do colaborador é: {salarioFinal} R$");
        Console.ReadLine();
    }
}
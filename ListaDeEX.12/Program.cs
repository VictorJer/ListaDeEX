internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        System.Console.Write("qual o seu salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double salario15 = salario + (salario * 0.15);
        double salario8 = salario15 - (salario15 * 0.08);

        System.Console.WriteLine($"salario base {salario}R$ com o aumento {salario15}R$ com imposto {salario8}R$");
    }
}
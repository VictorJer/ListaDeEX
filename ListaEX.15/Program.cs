internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("qual a sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("qual o seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());


        double IMC = peso / (altura * 2);

        if (IMC < 18.5)
        {
            System.Console.WriteLine("voçê esta abaixo do peso");
        }
        else if (IMC < 24.9)
        {
            System.Console.WriteLine("voçê esta com o peso ideal");
        }
        else if (IMC < 29.9)
        {
            System.Console.WriteLine("voçê esta com sobre peso");
        }
        else
        {
            System.Console.WriteLine("voçê esta com obesidade");
        }

        Console.ReadLine();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numero = new int[3];

        for (int j = 0; j <= 2; j++)
        {
            System.Console.WriteLine("Digite um numero inteiro: ");
            numero[j] = Convert.ToInt32(Console.ReadLine());
        }
        if (numero[0] > numero[1] && numero[0] > numero[2])
        {
            if (numero[1] > numero[2])
                Console.WriteLine($"{numero[0]}, {numero[1]}, {numero[2]}");
            else
                Console.WriteLine($"{numero[0]}, {numero[2]}, {numero[1]}");
        }
        else if (numero[1] > numero[0] && numero[1] > numero[2])
        {
            if (numero[0] > numero[2])
                Console.WriteLine($"{numero[1]}, {numero[0]}, {numero[2]}");
            else
                Console.WriteLine($"{numero[1]}, {numero[2]}, {numero[0]}");
        }
        else
        {
            if (numero[0] > numero[1])
                Console.WriteLine($"{numero[2]}, {numero[0]}, {numero[1]}");
            else
                Console.WriteLine($"{numero[2]}, {numero[1]}, {numero[0]}");

            Console.ReadLine();
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string? continuar;

        do
        {
            System.Console.WriteLine("Digite um numero que vc quer verificar se e primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool primo = true;

            if (numero <= 1)
            {
                primo = false;
                break;
            }
            else
            {
                for (int j = 2; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo == true)
            {
                System.Console.WriteLine("o numero é primo");
            }
            else
            {
                System.Console.WriteLine("o numero nãe é primo");
            }

            System.Console.WriteLine("você quer continuar (S/N): ");
            continuar = Console.ReadLine();

        } while (continuar?.ToUpper() == "S");
    }
}
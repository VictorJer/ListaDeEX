internal class Program
{
    private static void Main(string[] args)
    {

        System.Console.Write("quantas notas o aluno tem: ");
        int quantNotas = Convert.ToInt32(Console.ReadLine());

        double notaSomada = 0;

        for (int j = 1; j <= quantNotas; j++)
        {
            Console.Clear();
             
            System.Console.Write($"nota {j} do aluno: ");
            notaSomada += Convert.ToDouble(Console.ReadLine());
        }

        Console.Clear();
        
        double media = notaSomada / quantNotas;

        System.Console.WriteLine($"a media do aluno é {media.ToString("F2")}");


        Console.ReadLine();
    }
}











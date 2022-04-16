using System;
 
namespace aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o número x:");
           double x = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Digite o número y:");
           double y = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine($"O número x digitado foi {x} e o número y foi {y}");
           Console.WriteLine("-------- Trocando ... --------");
           double newx = y;
           double newy = x;
           
           Console.WriteLine($"O número x agora é {newx} e o número y é {newy}");

        }
    }
}

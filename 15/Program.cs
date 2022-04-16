using System;
 
namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número 3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double maior = 0;
            double menor = double.MaxValue;

            if (n1<menor){
                menor = n1;
            }

            if(n2<menor){
                menor = n2;
            }
            if(n3<menor){
                menor = n3;
            }

            if (n1>maior){
                maior = n1;
            }
            if (n2>maior){
                maior = n2;
            }
            if (n3>maior){
                maior = n3;
            }

            Console.WriteLine($"O maior número é {maior} e o menor é {menor}");

        }
    }
}

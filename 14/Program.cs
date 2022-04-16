using System;
 
namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Insira o numero 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Insira o numero 3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
 
            double maior = 0; 
 
            if (n1>maior){
                maior = n1;
            }
            if(n2>maior){
                maior = n2;
            }
            if(n3>maior){
                maior = n3;
            } 
             Console.WriteLine($"O maior valor é {maior}"); 
        }
    }
}

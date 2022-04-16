using System;
 
namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double delta = (B*B) - (4 * A * C);

            if(A==0){
                Console.WriteLine("A equação não é de segundo grau.");
            }
            
            else if(delta < 0){
                Console.WriteLine("A equação não possui raízes reais.");
            }
            
            else if(delta==0){
                double raiz = -(B) / (2 * A);
                Console.WriteLine($"A equação possui uma única raíz, que é igual a {raiz}");
            }
            
            else{
                double raiz1 = (-(B) + (Math.Sqrt(delta))) / (2 * A);
                double raiz2 = (-(B) - (Math.Sqrt(delta))) / (2 * A);
                Console.WriteLine($"A equação possui duas raízes.");
                Console.WriteLine($"Raíz 1 = {raiz1}");
                Console.WriteLine($"Raíz 2 = {raiz2}");
            }
        }
    }
}

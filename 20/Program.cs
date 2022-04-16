using System;
 
namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o lado A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o lado B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o lado C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if(A + B > C && B + C > A && A + C > B){
                if(A == B && A == C && B == C){
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if(A != B && A != C && B != C){
                    Console.WriteLine("O triângulo é escaleno.");
                }
                else{
                    Console.WriteLine("O triângulo é isósceles.");
                }
            }
            else{
                Console.WriteLine("Os lados não formam um triângulo.");
            }

        }
    }
}

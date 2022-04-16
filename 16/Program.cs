using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {

            List <double> numeros = new List<double>();

            for(int i=0; i<3; i++){
                Console.WriteLine($"Digite o número {i+1}: ");
                double N = Convert.ToDouble(Console.ReadLine());
                numeros.Add(N);
           }

           double maior = numeros.Max();
           double menor = numeros.Min();
           numeros.Remove(maior);
           numeros.Remove(menor);

           double meio = numeros[0];

           Console.WriteLine($"O número maior é {maior}, o do meio é {meio} e o menor é {menor}");
            
           
        }
    }
}

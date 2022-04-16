using System;
using System.Collections.Generic;
 
namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            for(int i =0; i<2; i++){
                Console.WriteLine($"Insira a nota {i+1}: " );
                double N = Convert.ToDouble(Console.ReadLine());
                notas.Add(N);
            }

            double media = notas.Average();
            Console.WriteLine($"As notas digitadas foram {notas[0]} e {notas[1]}");
            Console.WriteLine($"A média das notas foi {media}");

            if(media>9){
                Console.WriteLine("O conceito foi A.");
            }
            else if(media>7.5){
                Console.WriteLine("O conceito foi B.");
            }
            else if(media>6){
                Console.WriteLine("O conceito foi C.");
            }
            else if(media>4){
                Console.WriteLine("O conceito foi D.");
            }
            else{
                Console.WriteLine("O conceito foi E.");
            }

        }
    }
}

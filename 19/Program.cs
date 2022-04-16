using System;
using System.Collections.Generic;
 
namespace _19
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
            
            char conceito;

            if(media>9){
                conceito = 'A';
            }
            else if(media>7.5){
                conceito = 'B';
            }
            else if(media>6){
                conceito = 'C';
            }
            else if(media>4){
                conceito = 'D';
            }
            else{
                conceito = 'E';
            }

            Console.WriteLine($"O conceito recebido foi: {conceito}");

            if(conceito =='A' || conceito =='B' || conceito == 'C'){
                Console.WriteLine("Você foi aprovado.");
            }
            else{
                Console.WriteLine("Você foi reprovado.");
            }

        }
    }
}

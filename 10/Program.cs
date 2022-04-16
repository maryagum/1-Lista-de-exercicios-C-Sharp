using System;
 
namespace aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira o raio da circunferência: ");
            string strraio = Console.ReadLine();
            double raio = Convert.ToDouble(strraio);

            double diametro = raio*2;
            double area = Math.PI * (Math.Pow(raio,2));
            double comprimento = 2*Math.PI*raio;

            Console.WriteLine($"O diâmetro é {diametro}");
            Console.WriteLine($"A área é {area}");
            Console.WriteLine($"O comprimento é {comprimento}");
 
        }
    }
}

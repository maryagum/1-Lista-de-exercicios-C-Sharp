using System;
 
namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o peso: ");
            string peso_string = Console.ReadLine();
            double peso = Convert.ToDouble(peso_string);
 
            Console.WriteLine("Insira a altura: ");
            string altura_string = Console.ReadLine();
            double altura = Convert.ToDouble(altura_string);
 
            double IMC = peso / Math.Pow(altura, 2);
 
            if(IMC < 18.5){
                Console.WriteLine("Peso baixo.");
            }
            else if (IMC < 25){
                Console.WriteLine("Peso normal.");
            }
            else if(IMC < 30){
                Console.WriteLine("Sobrepeso");
            }
            else if(IMC < 35){
                Console.WriteLine("Obesidade.");
            }
            else if (IMC < 40){
                Console.WriteLine("Obesidade severa.");
            }
            else{
                Console.WriteLine("Obesidade mórbida.");
            }
 
        }
    }
}

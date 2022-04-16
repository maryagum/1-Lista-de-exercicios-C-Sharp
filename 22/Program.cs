using System;
 
namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número: ");
            double N = Convert.ToDouble(Console.ReadLine());
            if(N%100!=0 && N%4==0){
                Console.WriteLine("O ano é bissexto.");
            }
            else if(N%100==0 & N%400==0){
                Console.WriteLine("O ano é bissexto.");
            }
            else{
                Console.WriteLine("O ano não é bissexto. ");
            }
        }
    }
}

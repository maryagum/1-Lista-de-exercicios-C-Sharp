using System;
 
namespace aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Insira o dia do nascimento: ");
           double dia = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Insira o mês do aniversário: ");
           double mes = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Insira o ano do aniversário: ");
           double ano = Convert.ToInt32(Console.ReadLine());

            if(dia < 1 || dia > 30 || mes < 1 || mes > 12){
                Console.WriteLine("A data digitada é inválida.");
            }
            else{
                Console.WriteLine("A data é válida.");
            }
 
 
        }
    }
}

using System;
 
namespace aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Insira a idade: ");
           string stridade = Console.ReadLine();
           int idade = Convert.ToInt32(stridade);

           if(18<=idade && idade<=67){
               Console.WriteLine("Você pode doar sangue.");
           }
           else{
               Console.WriteLine("Você não pode doar sangue.");
           }

           
 
 
        }
    }
}

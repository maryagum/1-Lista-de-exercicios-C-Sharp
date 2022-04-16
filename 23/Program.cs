using System;
 
namespace aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string percentual;
            double salario_anterior;
            double salario_atual;
            double valor_aumento; 

            Console.WriteLine("Insira o salário atual: ");
            salario_anterior = Convert.ToDouble(Console.ReadLine());

            if(salario_anterior<=280){
                percentual = "20%";
                valor_aumento = (salario_anterior*20) / 100;
                salario_atual = salario_anterior+valor_aumento;
            }
            else if(salario_anterior<700){
                percentual = "15%";
                valor_aumento = (salario_anterior*15) / 100;
                salario_atual = salario_anterior+valor_aumento;
            }
            
            else if(salario_anterior<1500){
                percentual = "10%";
                valor_aumento = (salario_anterior*10) / 100;
                salario_atual = salario_anterior+valor_aumento;
            }
            else{
                percentual = "5%";
                valor_aumento = (salario_anterior*5) / 100;
                salario_atual = salario_anterior+valor_aumento;
            }

            Console.WriteLine($"O salário anterior era de {salario_anterior:c}");
            Console.WriteLine($"O percentual de aumento foi de {percentual}");
            Console.WriteLine($"O valor do aumento foi de {valor_aumento:c}");
            Console.WriteLine($"O valor do salário após o aumento é de {salario_atual:c}");

        }
    }
}

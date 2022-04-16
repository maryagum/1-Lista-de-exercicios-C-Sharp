using System;
 
namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_liquido;
            double IR=0;
            double sindicato;
            double FGTS;
            double total_descontos;
            double horas;
            double valor_hora;
            double salario_bruto;
            string IR_percentual;

            Console.WriteLine("Informe as horas trabalhadas: ");
            horas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora: (R$)");
            valor_hora = Convert.ToDouble(Console.ReadLine());
            salario_bruto = valor_hora*horas;
            
            if(salario_bruto<=1903.98){
                IR = 0;
                IR_percentual = "0%";
            }
            else if(salario_bruto<=2826.65){
                IR = (salario_bruto*7.5)/100;
                IR_percentual = "7,5%";
            }
            else if(salario_bruto<=3751.05){
                IR = (salario_bruto*15)/100;
                IR_percentual = "15%";
            }
            else if(salario_bruto<=4664.68){
                IR = (salario_bruto*22.5)/100;
                IR_percentual = "22,5%";
            }
            else{
                IR = (salario_bruto*27.5)/100;
                IR_percentual = "27,5%";
            }

            sindicato = (salario_bruto*3)/100;
            FGTS = (salario_bruto*11)/100;
            salario_liquido = salario_bruto - IR - sindicato;
            total_descontos = IR + sindicato;

            Console.WriteLine($"Horas trabalhadas: {horas}");
            Console.WriteLine($"Valor da hora: {valor_hora:c}");
            Console.WriteLine($"Salário bruto ({horas} * {valor_hora}): {salario_bruto:c}");
            Console.WriteLine($"( - ) IR ({IR_percentual}): {IR:c}");
            Console.WriteLine($"( - ) Sindicato (3%): {sindicato:c}");
            Console.WriteLine($"FGTS (11%): {FGTS:c}");
            Console.WriteLine($"Total de descontos: {total_descontos:c}");
            Console.WriteLine($"Salário líquido: {salario_liquido:c}");

        }
    }
}

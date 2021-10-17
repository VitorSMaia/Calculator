using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
{
            Console.WriteLine("Qual Tipo de Operação Você Gostaria de Fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            string escolha = Console.ReadLine();

            Console.WriteLine("Qual é o Primeiro Número?");
            float numeroI = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o Segundo Número?");
            float numeroII = float.Parse(Console.ReadLine());


           switch (escolha)
            {
                case "1": Response.Response.Soma(numeroI,numeroII);                break;
                case "2": Response.Response.Subtrair(numeroI,numeroII);            break;
                case "3": Response.Response.Multiplicar(numeroI,numeroII);         break;
                case "4": Response.Response.Dividir(numeroI,numeroII);             break;
                default:  Response.Response.Soma(numeroI,numeroII);                break;
            }
        }
    }
}

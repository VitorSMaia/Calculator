using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short operacao = Menu();
            float NumeroI = InputDados("Primeiro");
            float NumeroII = InputDados("Segundo");
            Escolha(operacao,NumeroI,NumeroII);
        }

        static short Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual Tipo de Operação Você Gostaria de Fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("<---------////--------->");

            short escolha = short.Parse(Console.ReadLine());
            return escolha;
        }


        static float InputDados(string ordem)
        {
            Console.WriteLine($"Qual é o {ordem} Número?");
            float numero = float.Parse(Console.ReadLine());

            return numero;
        }
        
        static void Escolha(short escolha, float numeroI, float numeroII)
        {
           switch (escolha)
            {
                case 1: Response.Response.Soma(numeroI,numeroII);                break;
                case 2: Response.Response.Subtrair(numeroI,numeroII);            break;
                case 3: Response.Response.Multiplicar(numeroI,numeroII);         break;
                case 4: Response.Response.Dividir(numeroI,numeroII);             break;
                default:  Response.Response.Soma(numeroI,numeroII);              break;
            }
        }
    }
}

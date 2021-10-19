using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short operacao = Menu();
            (float NumeroI,float NumeroII) = InputDados(operacao);
            Escolha(operacao,NumeroI,NumeroII);
        }

        static private short Menu()
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


        static private (float NumeroI, float NumeroII) InputDados(short operacao)
        {
            if(operacao == 0)
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine($"Qual é o Primeiro Número?");
            var numeroI = float.Parse(Console.ReadLine());
            Console.WriteLine($"Qual é o Segundo Número?");
            var numeroII = float.Parse(Console.ReadLine());

            return (numeroI,numeroII);
        }
        
        static private void Escolha(short escolha, float numeroI, float numeroII)
        {
            var Response = new Response();
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

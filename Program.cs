using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short operador = Menu();
            ValidaOpcao(operador);
            (float NumeroI,float NumeroII) = InputDados();
            Calcular(operador,NumeroI,NumeroII,0);
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

            short operacao = short.Parse(Console.ReadLine());
            return operacao;
        }
        static private (float NumeroI, float NumeroII) InputDados()
        {
            Console.WriteLine($"Qual é o Primeiro Número?");
            var numeroI = float.Parse(Console.ReadLine());
            Console.WriteLine($"Qual é o Segundo Número?");
            var numeroII = float.Parse(Console.ReadLine());

            ValidaDenominador(numeroII);

            return (numeroI,numeroII);
        }
        static private void Calcular(short operador, float numeroI, float numeroII, float resultado)
        {
            var operacao = new Calculadora(numeroI, numeroII);
            
            
            switch(operador)
            {
                case 1: 
                    resultado = operacao.Somar();
                    MostrarResultado(numeroI, numeroII, resultado);
                break;
                case 2: 
                    resultado = operacao.Subtrair();
                    MostrarResultado(numeroI, numeroII, resultado);
                break;
                case 3: 
                    resultado = operacao.Multiplicar();
                    MostrarResultado(numeroI, numeroII, resultado);
                break;
                case 4:
                    resultado = operacao.Dividir();
                    MostrarResultado(numeroI, numeroII, resultado);
                break;
                default:
                    Console.Write("Opção Inválida");
                    System.Environment.Exit(0);
                break;
            }
        }
        static private void MostrarResultado(float numeroI, float numeroII, float resultado)
        {
            var mensagem = new Resposta(numeroI, numeroII);
            string msg = mensagem.MensagemSomar(resultado);
            Console.WriteLine(msg);
        }
        static private void ValidaDenominador(float NumeroII)
        {
            if( NumeroII == 0 )
            {
                Console.WriteLine("O Denominador não pode ser 0!");
                System.Environment.Exit(0);
            }
        }
        static private void ValidaOpcao(float operador)
        {
            switch(operador)
            {
                case 1: 
                    Console.WriteLine("Para sua conta de soma escolha os valores:");
                break;
                case 2: 
                    Console.WriteLine("Para sua conta de subtrair escolha os valores:");
                break;
                case 3: 
                    Console.WriteLine("Para sua conta de multiplicar escolha os valores:");
                break;
                case 4:
                    Console.WriteLine("Para sua conta de dividir escolha os valores:");
                break;
                case 0:
                    Console.WriteLine("Obrigado por Participar, até mais !!!");
                    System.Environment.Exit(0);
                break;
                default:
                    Console.Write("Opção Inválida");
                    System.Environment.Exit(0);
                break;
            }
        }
    }
}

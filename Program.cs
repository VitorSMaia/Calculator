using System;

// using Resposta;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short operador = Menu();
            ValidaOpcao(operador);
            (float NumeroI,float NumeroII) = InputDados();
            Resultado(operador,NumeroI,NumeroII);
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
        static private void Resultado(short operador, float numeroI, float numeroII)
        {
            var operacao = new Calculadora.Calculadora(numeroI, numeroII);
            var mensagem = new Resposta.Resposta(numeroI, numeroII);
            
            switch(operador)
            {
                case 1: 
                    float resultadoSomar = operacao.Somar();
                    string msg = mensagem.MensagemSomar(resultadoSomar);
                    Console.WriteLine(msg);
                break;
                case 2: 
                    float resultadoSubtrair = operacao.Subtrair();
                    string msgSubtrair = mensagem.MensagemSubtrair(resultadoSubtrair);
                    Console.WriteLine(msgSubtrair);
                break;
                case 3: 
                    float resultadoMultiplicar = operacao.Multiplicar();
                    string msgMultiplicar = mensagem.MensagemMultiplicar(resultadoMultiplicar);
                    Console.WriteLine(msgMultiplicar);
                break;
                case 4:
                    float resultadoDividir = operacao.Dividir();
                    string msgDividir = mensagem.MensagemDividir(resultadoDividir);
                    Console.WriteLine(msgDividir);
                break;
                default:
                    Console.Write("Opção Inválida");
                    System.Environment.Exit(0);
                break;
            }
        }
        static private void ValidaDenominador(float NumeroII)
        {
            if( NumeroII == 0 )
            {
                Console.WriteLine("O Segundo Denominador não pode ser 0 !");
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

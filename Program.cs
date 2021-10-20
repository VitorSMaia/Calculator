using System;
using Calculate;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short operador = Menu();
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
            if(operacao == 0)
            {
                System.Environment.Exit(0);
            }
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
            var calculadora = new Calculadora(numeroI, numeroII);
            var mensagem = "";
            float resultado = 0;

            switch(operador)
            {
                case 1 : 
                    resultado = calculadora.Somar();
                    mensagem = $"O Resultado de {numeroI} + {numeroII} é igual {resultado}!";
                break;
                case 2 :
                    
                    resultado = calculadora.Subtrair();
                    mensagem = $"O Resultado de {numeroI} - {numeroII} é igual {resultado}!";
                break;
                case 3 :
                    resultado = calculadora.Multiplicar();
                    mensagem = $"O Resultado de {numeroI} * {numeroII} é igual {resultado}!";
                break;
                case 4 :
                    resultado = calculadora.Dividir();
                    mensagem = $"O Resultado de {numeroI} / {numeroII} é igual {resultado}!";
                break;
            }
            Console.WriteLine(mensagem);
        }
        private static void ValidaDenominador(float NumeroII)
        {
            if( NumeroII == 0 )
            {
                Console.WriteLine("O Denominador não pode ser 0!");
                System.Environment.Exit(0);
            }
        }
    }
    
}

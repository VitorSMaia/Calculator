using System;

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
            var operacao = new Calculadora(numeroI, numeroII);
            var mensagem = new Resposta(numeroI, numeroII);

            if(operador == 1)
            {
                    float resultado = operacao.Somar();
                    string msg = mensagem.MensagemSomar(resultado);
                    Console.WriteLine(msg);
            }
            else if(operador == 2)
            {
                    float resultado = operacao.Subtrair();
                    string msg = mensagem.MensagemSubtrair(resultado);
                    Console.WriteLine(msg);
            }
            else if(operador == 3)
            {
                    float resultado = operacao.Multiplicar();
                    string msg = mensagem.MensagemMultiplicar(resultado);
                    Console.WriteLine(msg);
            }
            else if(operador == 4)
            {
                    float resultado = operacao.Dividir();
                    string msg = mensagem.MensagemDividir(resultado);
                    Console.WriteLine(msg);
            }
        }

        private static void ValidaDenominador(float NumeroII)
        {
            if( NumeroII == 0 )
            {
                Console.WriteLine("O Segundo Denominador não pode ser 0 !");
                System.Environment.Exit(0);
            }
        }
    }
    class Calculadora
    {
        public float  NumeroI{get;set;}
        public float  NumeroII{get;set;}

        public Calculadora(float numeroI, float numeroII)
        {
            NumeroI = numeroI;
            NumeroII = numeroII;
        }

        public float Somar()
        {
            return NumeroI + NumeroII;
        }
        public float Subtrair()
        {
            return NumeroI - NumeroII;
        }
        public float Multiplicar()
        {
            return NumeroI * NumeroII;
        }
        public float Dividir()
        {
            return NumeroI / NumeroII;
        }
    }
    class Resposta
    {
        public float NumeroI;
        public float NumeroII;
        public float Resultado;
        public Resposta(float numeroI, float numeroII)
        {
            NumeroI = numeroI;
            NumeroII = numeroII;
        }
        public string MensagemSomar(float resultado)
        {
            return $"O Resultado de {NumeroI} + {NumeroII} é igual {resultado}!";
        }
        public string MensagemSubtrair(float resultado)
        {
            return $"O Resultado de {NumeroI} - {NumeroII} é igual {resultado}!";
        }
        public string MensagemDividir(float resultado)
        {
            return $"O Resultado de {NumeroI} / {NumeroII} é igual {resultado}!";
        }
        public string MensagemMultiplicar(float resultado)
        {
            return $"O Resultado de {NumeroI} * {NumeroII} é igual {resultado}!";
        }
    }
}

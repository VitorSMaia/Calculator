using System;

namespace Calculator.Response
{
    public class Response
    {
        public static void Soma(float numeroI, float numeroII)
        {
            Console.WriteLine($"A Soma dos números {numeroI} e o {numeroII} é {Calculate.Calculate.SomaCalc(numeroI,numeroII)}");
        }
        public static void Subtrair(float numeroI, float numeroII)
        {
            Console.Write($"A Subtração dos números {numeroI} e o {numeroII} é {Calculate.Calculate.SubtrairCalc(numeroI,numeroII)}");
        }
        public static void Dividir(float numeroI, float numeroII)
        {
            if(numeroII == 0)
            {
                Console.WriteLine($"Error o Segundo número não pode ser {numeroII}");
            }else{
             Console.WriteLine("A Divisão dos números " + numeroI + " e o " + numeroII + " é " + Calculate.Calculate.DividirCalc(numeroI,numeroII));
            }
        }
        public static void Multiplicar(float numeroI, float numeroII)
        {
            Console.Write($"A Multiplicação dos números {numeroI} e o {numeroII} é {Calculate.Calculate.MultiplicarCalc(numeroI,numeroII)}");
        }
    }
}
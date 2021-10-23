using System;

namespace Calculator
{
    public class Resposta
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
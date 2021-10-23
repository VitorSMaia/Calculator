using System;

namespace Calculadora
{
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
}
using System;

namespace Calculator.Calculate
{
    public class Calculate
    {
        public static float SomaCalc(float numeroI, float numeroII)
        {
            float result = numeroI + numeroII;
            return result;
        }
        public static float SubtrairCalc(float numeroI, float numeroII)
        {
            float result = numeroI - numeroII;
            return result;
        }
        public static float DividirCalc(float numeroI, float numeroII)
        {
            float result = numeroI / numeroII;
            return result;
        }
        public static float MultiplicarCalc(float numeroI, float numeroII)
        {
            float result = numeroI * numeroII;
            return result;
        }
    }
}
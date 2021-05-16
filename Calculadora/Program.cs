using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            static double Soma(double n1, double n2)
            {
                return n1 + n2;
            }
            static double Subtracao(double n1, double n2)
            {
                return n1 - n2;
            }
            static double Multiplicacao(double n1, double n2)
            {
                return n1 * n2;
            }
            static double Divisao(double n1, double n2)
            {
                return n1 / n2;
            }
        }
    }
}

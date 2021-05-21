using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public List<double> Resultados = new List<double>();
        public double n1;
        public double n2;

        public double Soma(double n1, double n2, List<double> Resultados)
        {
            double result = n1 + n2;
            Resultados.Add(result);
            return result;
        }
        public double Subtracao(double n1, double n2, List<double> Resultados)
        {
            double result = n1 - n2;
            Resultados.Add(result);
            return result;
        }
        public double Multiplicacao(double n1, double n2, List<double> Resultados)
        {
            double result = n1 * n2;
            Resultados.Add(result);
            return result;

        }
        public double Divisao(double n1, double n2, List<double> Resultados)
        {
            double result = n1 / n2;
            Resultados.Add(result);
            return result;

        }
    }
}

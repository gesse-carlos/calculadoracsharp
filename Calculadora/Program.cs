using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> resultados = new List<double>();

            double n1;
            double n2;

            Console.WriteLine("Escolha qual operação deseja realizar: \r\n Soma \r\n Subtração \r\n Multiplicação \r\n Divisão \r\n Mostrar todos os resultados \r\n Sair");
            string operacao = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                switch (operacao)
                {
                    case "Soma":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Soma(n1, n2, resultados));
                        continue;
                    case "Subtração":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Subtracao(n1, n2, resultados));
                        continue;
                    case "Multiplicação":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Multiplicacao(n1, n2, resultados));
                        continue;
                    case "Divisão":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Divisao(n1, n2, resultados));
                        continue;
                    case "Mostrar todos os resultados":
                        Console.WriteLine(resultados);
                        continue;
                    case "Sair":
                        break;
                    default:
                        Console.WriteLine("Você precisa escolher uma operação");
                        break;

                }
            }
            
        }
        private static double Soma(double n1, double n2, List<double> resultados)
        {
            resultados.Add((double)(n1 + n2));
            return n1 + n2;

        }        
        private static double Subtracao(double n1, double n2, List<double> resultados)
        {
            resultados.Add((double)(n1 - n2));
            return n1 - n2;

        }
        private static double Multiplicacao(double n1, double n2, List<double> resultados)
        {
            resultados.Add((double)(n1 * n2));
            return n1 * n2;

        }private static double Divisao(double n1, double n2, List<double> resultados)
        {
            resultados.Add((double)(n1 / n2));
            return n1 / n2;

        }
        
    }
}

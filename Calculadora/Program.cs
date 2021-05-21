using System;
using System.Collections.Generic;


namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            double n1, n2;
            List<double> Resultados;

            var stoploop = false;

            while (stoploop == false)
            {
                Console.WriteLine("Escolha qual operação deseja realizar: \r\n Soma \r\n Subtração \r\n Multiplicação \r\n Divisão \r\n Mostrar todos os resultados \r\n Sair");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "Soma":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(calculadora.Soma(n1, n2, calculadora.Resultados));
                        continue;
                    case "Subtração":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(calculadora.Subtracao(n1, n2, calculadora.Resultados));
                        continue;
                    case "Multiplicação":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(calculadora.Multiplicacao(n1, n2, calculadora.Resultados));
                        continue;
                    case "Divisão":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(calculadora.Divisao(n1, n2, calculadora.Resultados));
                        continue;
                    case "Mostrar todos os resultados":
                        foreach (var i in calculadora.Resultados)
                        {
                            Console.WriteLine(i);
                        }
                        continue;
                    case "Sair":
                        stoploop = true;
                        break;
                    default:
                        Console.WriteLine("Você precisa escolher uma operação");
                        continue;

                }
            }
            
        }
        
        
    }
}

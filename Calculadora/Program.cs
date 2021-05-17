using System;
using System.Collections.Generic;


namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora n1, n2, Resultados;

            n1 = new Calculadora();
            n2 = new Calculadora();
            Resultados = new Calculadora();

            bool stoploop = false;

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
                        Console.WriteLine(Calculadora.Soma(n1, n2, Resultados));
                        continue;
                    case "Subtração":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Calculadora.Subtracao(n1, n2, Calculadora.Resultados));
                        continue;
                    case "Multiplicação":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Calculadora.Multiplicacao(n1, n2, Calculadora.Resultados));
                        continue;
                    case "Divisão":
                        Console.WriteLine("Digite o primeiro número da operação");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número da operação");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Calculadora.Divisao(n1, n2, Calculadora.Resultados));
                        continue;
                    case "Mostrar todos os resultados":
                        foreach (var i in Calculadora.Resultados)
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

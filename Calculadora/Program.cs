using System.Runtime.Serialization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculador n1, n2, calculadora;
            n1 = new Calculador();
            n2 = new Calculador();
            calculadora = new Calculador();
            double resultado;

            Console.WriteLine("                         Calculadora");
            bool continuar = true;
            while (continuar == true) { 
                Console.WriteLine("Digite o número correspontende ao calculo que deseja:");
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("| 1- Soma | 2- Subtração | 3- Multiplicação | 4- Divisão |");
                Console.WriteLine("----------------------------------------------------------");
                int operador = int.Parse(Console.ReadLine());
                if (operador > 4) {
                    Console.WriteLine("Número indisponível!");
                    break;
                }

                Console.WriteLine("Digite dois números q deseja calcular");
                Console.Write("Primeiro número: ");
                n1.num1 = double.Parse(Console.ReadLine());
                Console.Write("Segundo número: ");
                n2.num2 = double.Parse(Console.ReadLine());
                 
                switch (operador) {
                    case 1:
                        resultado = calculadora.Somar(n1.num1, n2.num2);
                        Console.WriteLine( "Resultado: {0}", resultado );
                        break;
                    case 2:
                        resultado = calculadora.Subtrair(n1.num1, n2.num2);
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                    case 3:
                        resultado = calculadora.Multiplicar(n1.num1, n2.num2);
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                    case 4:
                        resultado = calculadora.Dividir(n1.num1, n2.num2);
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                }

                Console.WriteLine("Deseja repetir?");
                string repetir = Console.ReadLine();
                if (repetir == "sim" || repetir == "Sim")
                {
                    continuar = true;
                }
                else {
                    continuar = false;
                }

            }

        }
    }
}
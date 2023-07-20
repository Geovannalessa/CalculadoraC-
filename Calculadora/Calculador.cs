using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculador
    {
        public double num1;
        public double num2;
       
        public double Somar(double numero1,double numero2)
        {
            this.num1 = numero1;
            this.num2 = numero2;
            double soma = numero1 + numero2;
            return soma;
        }
        public double Subtrair(double numero1, double numero2)
        {
            this.num1 = numero1;
            this.num2 = numero2;
            double subtrair = numero1 - numero2;
            return subtrair;
        }
        public double Multiplicar(double numero1, double numero2)
        {
            this.num1 = numero1;
            this.num2 = numero2;
            double multiplicar = numero1 * numero2;
            return multiplicar;
        }
        public double Dividir(double numero1, double numero2)
        {
            this.num1 = numero1;
            this.num2 = numero2;
            double dividir = numero1 / numero2;
            return dividir;
        }
    }
}

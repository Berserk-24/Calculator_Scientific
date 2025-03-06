using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Scientific.Operaciones
{
    public static class Op_Basicas
    {
        public static double Sumar(double a, double b) => a + b;
        public static double Restar(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;
        public static double Dividir(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("No se puede dividir por cero.");
    }
}

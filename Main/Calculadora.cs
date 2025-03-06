using Calculator_Scientific.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Scientific.Main
{
    public class Calculadora
    {
        public static double Calcular(string operacion, params double[] valores)
        {
            switch (operacion)
            {
                case "suma": return Op_Basicas.Sumar(valores[0], valores[1]);
                case "resta": return Op_Basicas.Restar(valores[0], valores[1]);
                case "multiplicacion": return Op_Basicas.Multiplicar(valores[0], valores[1]);
                case "division": return Op_Basicas.Dividir(valores[0], valores[1]);

                //case "seno": return OperacionesTrigonométricas.Seno(valores[0]);
                //case "coseno": return OperacionesTrigonométricas.Coseno(valores[0]);
                //case "logaritmo": return OperacionesLogaritmicas.Logaritmo(valores[0]);

                // Agregar más casos aquí

                default: throw new ArgumentException("Operación no reconocida.");
            }
        }
    }
}


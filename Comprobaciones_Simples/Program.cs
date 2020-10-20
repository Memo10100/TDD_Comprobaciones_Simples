using System;

namespace CS
{
    public class Calculos
    {
        public static void Main()
        {
            Console.WriteLine("Comprobacion De Un String");
            //Console.WriteLine("comprobacion de un string");
            //Console.WriteLine("Juan Gonzalez");
        }

        public static int Calcular_Suma(int N1, int N2)
        {
            return N1 + N2;
        }

        public static int Calcular_Resta(int N1, int N2)
        {
            return N1 - N2;
        }

        public static double Calcular_Multiplicacion(double N1, double N2)
        {
            return N1 * N2;
        }

        public static int Calcular_division(int N1, int N2)
        {

            //if (N2 == 0)
            //{
            //    throw new DivideByZeroException("No Se Puede Dividir Entre Cero...");
            //}
            //return N1 / N2;

            return N1 / N2;
        }
    }
}
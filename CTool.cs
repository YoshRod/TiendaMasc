using System;

namespace TiendaMas
{
    public class CTool
    {
        /// <summary>
        /// Evalua si el valor ingresado es un numero, de ser asi lo retorna.
        /// </summary>
        /// <returns>Valor ingresado en int.</returns>
        public static int EvaluaNumeroInt()
        {
            int numero = 0;
            bool conver = false;
            while (conver != true)
            {
                conver = int.TryParse(Console.ReadLine(), out numero);
                if (conver == false)
                    Console.WriteLine("Ingresa un numero entero");
            }
            return numero;
        }

        /// <summary>
        /// Evalua si el valor ingresado es un numero, de ser asi lo retorna.
        /// </summary>
        /// <returns>Valor ingresado en double.</returns>
        public static double EvaluaNumeroDou()
        {
            double numero = 0;
            bool conver = false;
            while (conver != true)
            {
                conver = double.TryParse(Console.ReadLine(), out numero);
                if (conver == false)
                    Console.WriteLine("Ingresa un numero entero");
            }
            return numero;
        }
    }
}

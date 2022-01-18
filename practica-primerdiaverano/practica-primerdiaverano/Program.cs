using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_primerdiaverano
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora de montos");
            Console.WriteLine("");

            double precio;
            int cantidad;

            Console.Write("cantidad");
            cantidad = int.Parse(Console.ReadLine());
            Console.Write("precio: ");
            precio = double.Parse(Console.ReadLine());

            double monto = cantidad * precio;

            Console.WriteLine("___________________");
            Console.WriteLine("monto a cancelar $" + monto.ToString("0.00"));

            Console.WriteLine("monto:" + monto);
            Console.ReadKey();

        }
    }
}

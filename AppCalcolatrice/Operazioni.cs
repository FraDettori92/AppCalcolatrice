using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Operazioni
    {
        public delegate double Del(double a, double b);

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static double Differenza(double a, double b)
        {
            return a - b;
        }

        public static double Prodotto(double a, double b)
        {
            return a * b;
        }

        public static double Quoziente(double a, double b)
        {
            return a / b;
        }
    }
}
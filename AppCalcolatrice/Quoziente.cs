using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Quoziente : IOperazione
    {
        public double Esegui(double a, double b)
        {
            return a / b;
        }
    }
}
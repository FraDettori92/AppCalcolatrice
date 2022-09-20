using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal interface IOperazione
    {
        public double Esegui(string inputUtente);
    }
}
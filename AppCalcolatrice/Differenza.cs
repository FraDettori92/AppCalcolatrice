using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Differenza : IOperazione
    {
        public double Esegui(string inputUtente)
        {
            string[] arrayNum = inputUtente.Split('-');
            double risultato = double.Parse(arrayNum[0]);
            for (int i = 1; i < arrayNum.Length; i++)
            {
                double num = double.Parse(arrayNum[i]);
                risultato -= num;
            }
            return risultato;
        }
    }
}
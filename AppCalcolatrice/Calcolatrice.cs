using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Calcolatrice
    {
        public delegate double Del(double a, double b);

        private IOperazione Operazione(string inputUtente)
        {
            if (inputUtente.Contains('+')) 
            {
                return new Somma();
            }
            else if (inputUtente.Contains('-')) 
            { 
                return new Differenza(); 
            }
            else if (inputUtente.Contains('*')) 
            {
                return new Prodotto();
            }
            else if (inputUtente.Contains('/')) 
            { 
                return new Quoziente(); 
            }
            else return null;
        }

        public void ProcessaSoluzione(string inputUtente)
        {
            double a = 20;
            double b = 10;

            var ogg = Operazione(inputUtente);
            Del del = new Del(ogg.Esegui);
            Console.WriteLine($"{"Il risultato è: "} {del(a, b)}");
        }

        public void HomeCalcolatrice()
        {
            Console.WriteLine("Quale operazione vorresti svolgere?:\n+: Somma\n-: Differenza\n*: Prodotto\n/: Quoziente");
        }
    }
}
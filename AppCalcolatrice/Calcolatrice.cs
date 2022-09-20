using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Calcolatrice
    {
        private IOperazione Operazione(string inputUtente)
        {
            if (inputUtente.Contains('+')) { return new Somma(); }
            else if (inputUtente.Contains('-')) { return new Differenza(); }
            else if (inputUtente.Contains('*')) { return new Prodotto(); }
            else if (inputUtente.Contains('/')) { return new Quoziente(); }
            else return null;
        }

        public void ProcessaRisultato(string inputUtente)
        {
            double a = 10;
            double b = 15;

            var opp = Operazione(inputUtente);
            var risultato = nuovometodo(a, b, opp);
            Console.WriteLine(risultato);
        }

        private double nuovometodo(double a, double b, IOperazione q)
        {
            return q.Esegui(a, b);
        }

        public void HomeCalcolatrice()
        {
            Console.WriteLine("Quale operazione vorresti svolgere?:\n+: Somma\n-: Differenza\n*: Prodotto\n/: Quoziente");
        }
    }
}
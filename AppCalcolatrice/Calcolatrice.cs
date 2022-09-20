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
            var opp = Operazione(inputUtente);
            if (opp != null)
            {
                Console.WriteLine($"Il risultato è: {opp.Esegui(inputUtente)}");
            }
            else
            {
                Console.WriteLine("Operazione non supportata!");
            }
        }
    }
}
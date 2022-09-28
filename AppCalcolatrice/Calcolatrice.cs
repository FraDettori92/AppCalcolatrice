using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcolatrice
{
    internal class Calcolatrice
    {
        public void Operazione(string inputUtente)
        {
            Operazioni.Del del = null;

            Console.WriteLine("Inserisci il primo numero: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            double b = Double.Parse(Console.ReadLine());

            if (inputUtente.Contains('+')) 
            {
                del = Operazioni.Somma;
            }

            else if (inputUtente.Contains('-'))
            {
                del = Operazioni.Differenza;
            }
            else if (inputUtente.Contains('*'))
            {
                del = Operazioni.Prodotto;
            }
            else if (inputUtente.Contains('/'))
            {
                del = Operazioni.Quoziente;
            }
            else
            {
                Console.WriteLine("Operazione non valida!");
            }

            if(del != null)
            {
                double risultato = del(a, b);
                Console.WriteLine($"Il risultato è: {risultato}");
            }
            else Console.WriteLine("Errore!");
        }

        public void HomeCalcolatrice()
        {
            Console.WriteLine("\nQuale operazione vorresti svolgere?\n+ ---> Somma\n- ---> Differenza\n* ---> Prodotto\n/ ---> Quoziente");
            string inputUtente = Console.ReadLine();

            if(inputUtente.Contains('+') || inputUtente.Contains('-') || inputUtente.Contains('*') || inputUtente.Contains('/'))
            {
                Operazione(inputUtente);
            }
            else Console.WriteLine("Operazione non valida!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Inserimento di uno o più lavoratori (sugg:ARRAY)
 * anagrafica del lavoratore (nome, cognome, ecc)
 * stipendio del lavoratore ( RAL annuale )
 * anni di anzianità del lavoratore 
 * discernere tra lavoatori autonomi e lavoratori dipendenti 
 * fornire METODI che forniscono info su:
 * 
 *      -stipendio mensile del singoolo lavoratore
 *      - visualizzazione lista dei lavoratori inseriti
 *      - ordinamento dei lavoratori per stipendio 
 *      - ordinamento dei lavoratori per anzianità
 *      
 * Calcolare l'input delle tasse da pagare supponendo che il calcolo sia:
 *      -LAVORATORI AUTONOMI:
 *          .RAL < 50000 ---> tasse = 15% RAL
 *          .RAL >= 50000 --->tasse = 30% RAL
 * 
 */
namespace ProgettoLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stipendio mensile del primo lavoratore");
            Lavoratore l1 = new Lavoratore("Federico", "Sacco", Sesso.M, 15600, 2);
            Console.WriteLine(l1.stipendioMensile(l1));

            Console.WriteLine("Stipendio mensile del secondo lavoratore");
            Lavoratore l2 = new Lavoratore("Matteo", "Verdi", Sesso.M, 14400, 1);
            Console.WriteLine(l2.stipendioMensile(l2));

            Console.WriteLine("Stipendio mensile del terzo lavoratore");
            Lavoratore l3 = new Lavoratore("Cristian", "Lo Capo", Sesso.M, 25320, 30);
            Console.WriteLine(l3.stipendioMensile(l3));

            Console.WriteLine("Stipendio mensile del quarto lavoratore");
            Lavoratore l4 = new Lavoratore("Jacopo", "Lento", Sesso.M, 40150, 49);
            Console.WriteLine(l4.stipendioMensile(l4));


            Console.WriteLine("Ordinamento Stipendio:");
            Lavoratore.ordinamentoStipendio(Lavoratore[i]);
            Console.ReadLine();

            Console.WriteLine("Ordinamento Stipendio:");
            Lavoratore.stpendioMensile(l1);

          

            

            Console.ReadLine();
        }
    }

}

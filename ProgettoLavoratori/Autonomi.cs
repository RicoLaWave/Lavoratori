using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoLavoratori
{
    public class LavoratoriAutonomi : Lavoratore
    {
        public int RAL { get; set; }
        public LavoratoriAutonomi()
        {

        }
        public LavoratoriAutonomi(string nome, string cognome, Sesso genere, DateTime dataDiNascita,
                        int stipendioMensile) : base(nome, cognome, genere, dataDiNascita, stipendioMensile) 
        {

        }

        public LavoratoriAutonomi(string nome, string cognome, DateTime dataDiNascita, int stipendioMensile) : base(nome, cognome, dataDiNascita, stipendioMensile)
        {
            
        }

        public override string GetDettaglioLavoratori()
        {
            try
            {
                RAL = StipendioMensile * 12;
                return base.GetDettaglioLavoratori() + Environment.NewLine
                    + RAL + " ANNUAL SALARY ";
            }
            catch
            {
                Console.WriteLine("Errore nei dettagli del lavoratore");
            }
        }

        public int CalcoloTasseAut() 
        {
            try
            {
                int tasse;
                if (RAL < 50000)
                {
                    tasse = (RAL * 15) / 100;
                }
                else
                {
                    tasse = (RAL * 30) / 100;
                }

                return tasse;
            }
            catch
            {
                Console.WriteLine("Errore nel calcolo delle tasse");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoLavoratori
{
    public class LavoratoriDipendenti : Lavoratore
    {
        public int RAL { get; set; }
        public int AnnoAssunzione { get; set; }
        public LavoratoriDipendenti (string nome, string cognome, DateTime dataDiNascita, int stipendioMensile, int annoAssunzione) 
                          : base(nome, cognome, dataDiNascita, stipendioMensile, annoAssunzione) 
        {

        }

        public override string GetDettaglioLavoratori()
        {
            try
            {
                RAL = StipendioMensile * 13;
            }
            catch
            {
                Console.WriteLine("Errore nei dettagli del lavoratore");
            }
            return base.GetDettaglioLavoratori() + Environment.NewLine
                 + RAL + " stipendio annuale" + Environment.NewLine;
        }
        public int CalcoloAnzianità(int annoAssunzione) 
        {
            int result = 0;
            try
            {
                result = DateTime.Now.Year - annoAssunzione;
            }
            catch
            {
                Console.WriteLine("Errore nel calcolo di anzianità lavoratore");
            }
            return result;
        }
        public int CalcoloTasseDip() 
        {
            int tasse = 0;

            try
            {
                if (RAL < 6000)
                {
                    tasse = 0;
                }
                else if (RAL >= 6000 && RAL < 15000)
                {
                    tasse = (RAL * 15) / 100;
                }
                else if (RAL >= 15000 && RAL < 25000)
                {
                    tasse = (RAL * 30) / 100;
                }
                else if (RAL >= 25000 && RAL < 35000)
                {
                    tasse = (RAL * 40) / 100;
                }
                else
                {
                    tasse = (RAL * 50) / 100;
                }
                return tasse;
            }
            catch
            {
                Console.WriteLine("ERRORE NEL CALCOLO DELLE TASSE DEL DIPENDENTE");
            }
            finally
            {
                Console.WriteLine("Grazie per avere utitlizzato il nostro software");
            }
            

        }
    }
}

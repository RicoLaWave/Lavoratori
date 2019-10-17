using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoLavoratori
{
    enum Sesso
    {
        M, 
        F
    }
    public class Lavoratore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Sesso Genere { get; set; }
        public float Stipendio { get; set; }
        public int AnniAnzianità { get; set; }

        //Costruttore della classe LAVORATORE;
        public Lavoratore (string nome, string cognome, Sesso genere, float stipendio, int anniAnzianità)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Genere = genere;
            this.Stipendio = stipendio;
            this.AnniAnzianità = anniAnzianità;
        }

        public int stipendioMensile(float stipendio)
        {
            try{

                return stipendioMensile;
            }

            catch(Exception ex){
                Console.WriteLine("Lo stipendio inserito non è valido");
                Console.ReadLine(ex);
            }
        }
       
        public void listaLavoratori()  //ARRAY
        {

            try{
                Lavoratore[] lavoratori = new Lavoratore[4];
            
                lavoratori[0] = new Lavoratore("Federico", "Sacco", Sesso.M, 15600, 2);
                lavoratori[1] = new Lavoratore("Matteo", "Verdi", Sesso.M, 13400, 1);
                lavoratori[2] = new Lavoratore("Cristian", "Lo Capo", Sesso.M, 25320, 30);
                lavoratori[3] = new Lavoratore("Jacopo", "Lento", Sesso.M, 40150, 49);

                for (int i = 0; i < lavoratori.Length; i++)
                {
                     Console.WriteLine(lavoratori[i].Nome
                         + lavoratori[i].Cognome
                         + lavoratori[i].Genere
                         + lavoratori[i].Stipendio
                         + lavoratori[i].AnniAnzianità
                      );
                }
            }    
            catch(ArrayTypeMismatchException aex){
                Console.WriteLine("Errore nella visualizzazione della lista lista lavoratori");
                Console.ReadLine(aex.Message);
            }
            finally{
                 Console.WriteLine("Grazie di tutto, alla prossima");
            }              
        }
        public static Lavoratore[] ordinamentoStipendio ()
        {
            try{
                 Lavoratore i; 
                 Lavoratore[] lavoratori = new Lavoratore[4];

                 lavoratori[0] = new Lavoratore("Federico", "Sacco", Sesso.M, 15600, 2);
                 lavoratori[1] = new Lavoratore("Matteo", "Verdi", Sesso.M, 13400, 1);
                 lavoratori[2] = new Lavoratore("Cristian", "Lo Capo", Sesso.M, 25320, 30);
                 lavoratori[3] = new Lavoratore("Jacopo", "Lento", Sesso.M, 40150, 49);

                Array.Sort(lavoratori);
                return lavoratori;
            }
            catch{
                Console.WriteLine("Errore nell'ordinamento dello stipendio");
            }
            finally{
                 Console.WriteLine("Grazie di tutto, alla prossima");
            }  
        }

        private static object OrderBy(float stipendio)
        {
            throw new NotImplementedException();
        }

        public Lavoratore stipendioMensile(Lavoratore l)
        {
            try{
                float stipendioMensileTot = (l.Stipendio/ 12);
                return stipendioMensileTot;
            }
            catch{
                Console.WriteLine("Errore nel calcolare lo stipendio mensile del lavoratore");
            }
            finally{
                 Console.WriteLine("Grazie di tutto, alla prossima");
            }   
        }
    }
}
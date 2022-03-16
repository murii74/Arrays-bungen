using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int Note = 0;
            int anzahlschueler = 20;
            
            int[] noten = new int[anzahlschueler];
            
            int Notensumme = 0;
            
            for (int anzahlSchul = 0; anzahlSchul < anzahlschueler; anzahlSchul++)
            {
                int Anzahl = 0;

                
                Console.WriteLine("Schüler {0}", anzahlSchul);
                


                Note = Convert.ToInt32(Console.ReadLine());
                noten[anzahlSchul] = Note;

                noten[anzahlSchul] = Note;
                Notensumme = Notensumme + Note;
                
            }

            float NotenDurch = 0f;
            NotenDurch = Notensumme / anzahlschueler;
            Console.WriteLine("Der Noten durchschnitt liegt bei:" + NotenDurch);
             //deniz kartal und murtaza behzad
        }
    }
}
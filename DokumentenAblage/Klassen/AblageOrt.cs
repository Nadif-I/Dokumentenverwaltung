using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace DokumentenAblage
{
    /*
    1)	Entwickeln Sie eine Klasse für den Ablageort mit folgenden
	Informationen:
	Stockwerk, Raumnummer, Regalnummer, Fach
    */

    public class AblageOrt
    {
        //Felder
        public string stockwerk;
        public int raumNummer;
        public int regalNummer;
        public string fach;

        // Konstruktoren
        public AblageOrt(string ablageOrt, int raumNummer, int regalNummer, string fach)
        {
            this.stockwerk = ablageOrt;
            this.raumNummer = raumNummer;
            this.regalNummer = regalNummer;
            this.fach = fach;
        }

        public void AblageOr()
        {
            Console.WriteLine($"Ablageort: {stockwerk}");
            Console.WriteLine($"Raum: {raumNummer}");
            Console.WriteLine($"Regal: {regalNummer}");
            Console.WriteLine($"Fach: {fach}");
            
        }
        


    }
}


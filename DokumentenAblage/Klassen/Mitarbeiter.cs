using System;
namespace DokumentenAblage
{
    /*
    Entwickeln Sie eine Klasse für den Verantwortlichen mit 
    folgenden Informationen:
    Name, Büronummer, Abteilung
    */

    public class Mitarbeiter
    {
        // Felder
        public string name;
        public int bueroNr;
        public string abteilung;

        // Konstruktoren
        public Mitarbeiter(string name, int bueroNr, string abteilung)
        {
            this.name = name;
            this.bueroNr = bueroNr;
            this.abteilung = abteilung;
        }

        public void Mitarbter()
        {
            Console.WriteLine($"Verantwortlicher: {name}");
            Console.WriteLine($"Büro Nr.: {bueroNr}");
            Console.WriteLine($"Abteilung: {abteilung}\n");
            
        }
    }
}


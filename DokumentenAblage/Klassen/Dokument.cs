using System;
namespace DokumentenAblage
{
    /*
    Entwickeln Sie eine Klasse für ein Dokument mit folgenden
    Informationen:
    DokumentenNr, Datum der Erstellung, Ablageort,
    Verantwortlicher, Kurzbeschreibung des Inhalts

    4)	Erstellen Sie 5 Dokumente mit allen Feldern
    */
    public class Dokument
    {
        // Felder
        public string dokuNr;
        public DateOnly erstDatum;
        public string name;
        public string beschreibung;

        // Konstruktoren
        public Dokument(string dokuNr, DateOnly erstDatum, string beschreibung)
        {
            this.dokuNr = dokuNr;
            this.erstDatum = erstDatum;
            this.name = name;
            this.beschreibung = beschreibung;
        }

        public void Doku()
        {
            Console.WriteLine($"Dokumenten Nr.: {dokuNr}\n");
            Console.WriteLine($"Erstellt am: {erstDatum}");           
            Console.WriteLine($"Beschreibung: {beschreibung}\n");

        }
    }
}


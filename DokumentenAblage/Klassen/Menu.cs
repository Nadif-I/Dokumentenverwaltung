using System;
namespace DokumentenAblage
{
    internal static class Menu
    {
        public static void Menue()
        {

            Dokument dokument1 = new Dokument("1. BND", new(2022, 01, 12), "Kurz Beschreibung");
            Dokument dokument2 = new Dokument("2. MI6", new(2022, 11, 10), "Kurz Beschreibung");
            Dokument dokument3 = new Dokument("3. Nescar", new(2022, 07, 15), "Kurz Beschreibung");
            Dokument dokument4 = new Dokument("4. KGB", new(2022, 02, 01), "Kurz Beschreibung");
            Dokument dokument5 = new Dokument("5. Riccola", new(2022, 10, 03), "Kurz Beschreibung");

            AblageOrt ort1 = new AblageOrt("Keller", 12, 1, "A");
            AblageOrt ort2 = new AblageOrt("Keller", 1, 2, "B");
            AblageOrt ort3 = new AblageOrt("1.OG", 5, 6, "C");
            AblageOrt ort4 = new AblageOrt("2.OG", 2, 1, "D");
            AblageOrt ort5 = new AblageOrt("3.OG", 4, 4, "D");

            Mitarbeiter name1 = new Mitarbeiter("Ilyass Nadif", 1, "BND");
            Mitarbeiter name2 = new Mitarbeiter("Dietrich Bond", 007, "MI6");
            Mitarbeiter name3 = new Mitarbeiter("Frank McQueen", 2, "Nescar");
            Mitarbeiter name4 = new Mitarbeiter("Alex Dering", 3, "KGB");
            Mitarbeiter name5 = new Mitarbeiter("Georg Schweitzer", 4, "Riccola");



            string eingabe;

            Console.WriteLine("Wählen Sie bitte aus den Dokumenten 1-5:\n[1] BND\n[2] MI6\n[3] Nescar\n[4] KGB\n[5] Riccola\n\nDeine Wahl:");
            eingabe = Console.ReadLine();
            Console.WriteLine();

            switch (eingabe)
            {
                case "1":
                    {
                        dokument1.Doku();
                        name1.Mitarbter();
                        ort1.AblageOr();
                        break;
                    }
                case "2":
                    {
                        dokument2.Doku();
                        name2.Mitarbter();
                        ort1.AblageOr();
                        break;
                    }
                case "3":
                    {
                        dokument3.Doku();
                        name3.Mitarbter();
                        ort3.AblageOr();
                        break;
                    }
                case "4":
                    {
                        dokument4.Doku();
                        name4.Mitarbter();
                        ort4.AblageOr();
                        break;

                    }
                case "5":
                    {
                        dokument5.Doku();
                        name5.Mitarbter();
                        ort5.AblageOr();
                        break;

                    }
                default:
                    Console.WriteLine("Bitte nur eine Ziffer eingeben!\n");
                    break;
            }
            Console.WriteLine("\nBeliebige Taste Drücken");
            Console.ReadKey();
            Console.Clear();



        }
    }
}


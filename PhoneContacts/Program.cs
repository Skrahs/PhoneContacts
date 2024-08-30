using PhoneContacts.Models;
using PhoneContacts.Services;
using System;

namespace PhoneContacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Rubrica rubrica = new Rubrica();
            string filePath = "rubrica.json";

            Console.WriteLine("Gestione Rubrica Telefonica");
            Console.WriteLine("1. Aggiungi contatto");
            Console.WriteLine("2. Visualizza contatti");
            Console.WriteLine("3. Cerca contatto");
            Console.WriteLine("4. Elimina contatto");
            Console.WriteLine("5. Modifica contatto");
            Console.WriteLine("6. Salva su file");
            Console.WriteLine("7. Carica da file");
            Console.WriteLine("8. Esci");

            bool running = true;
            while (running)
            {
                Console.Write("Scegli un'opzione (1-8): ");
                var scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        rubrica.AggiungiContatto();
                        break;
                    case "2":
                        rubrica.VisualizzaContatti();
                        break;
                    case "3":
                        rubrica.CercaContatto();
                        break;
                    case "4":
                        rubrica.EliminaContatto();
                        break;
                    case "5":
                        rubrica.ModificaContatto();
                        break;
                    case "6":
                        GestioneFile.SalvaRubricaSuFile(rubrica, filePath);
                        Console.WriteLine("Rubrica salvata su file.");
                        break;
                    case "7":
                        rubrica = GestioneFile.CaricaRubricaDaFile(filePath);
                        Console.WriteLine("Rubrica caricata da file.");
                        break;
                    case "8":
                        running = false;
                        Console.WriteLine("Uscita...");
                        break;
                    default:
                        Console.WriteLine("Opzione non valida.");
                        break;
                }
            }
        }
    }
}

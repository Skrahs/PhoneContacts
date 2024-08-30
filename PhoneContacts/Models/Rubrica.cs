using System;
using System.Collections.Generic;

namespace PhoneContacts.Models
{
    public class Rubrica
    {
        private List<Contatto> contatti;

        public Rubrica()
        {
            contatti = new List<Contatto>();
        }

        public void AggiungiContatto()
        {
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci il numero di telefono: ");
            string numeroTelefono = Console.ReadLine();

            Console.Write("Inserisci l'email: ");
            string email = Console.ReadLine();

            Contatto nuovoContatto = new Contatto(nome, numeroTelefono, email);
            contatti.Add(nuovoContatto);

            Console.WriteLine("Contatto aggiunto con successo!");
        }

        public void VisualizzaContatti()
        {
            if (contatti.Count == 0)
            {
                Console.WriteLine("La rubrica è vuota.");
            }
            else
            {
                Console.WriteLine("\n--- Elenco dei Contatti ---");
                foreach (var contatto in contatti)
                {
                    Console.WriteLine(contatto);
                }
            }
        }

        public void CercaContatto()
        {
            Console.Write("Inserisci il nome da cercare: ");
            string nomeCercato = Console.ReadLine();

            bool trovato = false;
            foreach (var contatto in contatti)
            {
                if (contatto.Nome.Equals(nomeCercato, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contatto trovato:");
                    Console.WriteLine(contatto);
                    trovato = true;
                    break;
                }
            }

            if (!trovato)
            {
                Console.WriteLine("Contatto non trovato.");
            }
        }

        public void EliminaContatto()
        {
            Console.Write("Inserisci il nome del contatto da eliminare: ");
            string nomeCercato = Console.ReadLine();

            Contatto contattoDaRimuovere = contatti.Find(c => c.Nome.Equals(nomeCercato, StringComparison.OrdinalIgnoreCase));

            if (contattoDaRimuovere != null)
            {
                contatti.Remove(contattoDaRimuovere);
                Console.WriteLine("Contatto eliminato con successo.");
            }
            else
            {
                Console.WriteLine("Contatto non trovato.");
            }
        }

        public void ModificaContatto()
        {
            Console.Write("Inserisci il nome del contatto da modificare: ");
            string nomeCercato = Console.ReadLine();

            Contatto contattoDaModificare = contatti.Find(c => c.Nome.Equals(nomeCercato, StringComparison.OrdinalIgnoreCase));

            if (contattoDaModificare != null)
            {
                Console.Write("Inserisci il nuovo nome (lascia vuoto per mantenere invariato): ");
                string nuovoNome = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuovoNome))
                {
                    contattoDaModificare.Nome = nuovoNome;
                }

                Console.Write("Inserisci il nuovo numero di telefono (lascia vuoto per mantenere invariato): ");
                string nuovoNumero = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuovoNumero))
                {
                    contattoDaModificare.NumeroTelefono = nuovoNumero;
                }

                Console.Write("Inserisci la nuova email (lascia vuoto per mantenere invariato): ");
                string nuovaEmail = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuovaEmail))
                {
                    contattoDaModificare.Email = nuovaEmail;
                }

                Console.WriteLine("Contatto modificato con successo.");
            }
            else
            {
                Console.WriteLine("Contatto non trovato.");
            }
        }

        public List<Contatto> GetContatti()
        {
            return contatti;
        }

        public void SetContatti(List<Contatto> contatti)
        {
            this.contatti = contatti;
        }
    }
}

using PhoneContacts.Models;
using PhoneContacts.Services;
using System;

namespace PhoneContacts
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            string filePath = "addressBook.json";

            Console.WriteLine("Address Book Management");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contacts");
            Console.WriteLine("3. Search contact");
            Console.WriteLine("4. Delete contact");
            Console.WriteLine("5. Edit contact");
            Console.WriteLine("6. Save to file");
            Console.WriteLine("7. Load from file");
            Console.WriteLine("8. Exit");

            bool running = true;
            while (running)
            {
                Console.Write("Choose an option (1-8): ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBook.AddContact();
                        break;
                    case "2":
                        addressBook.DisplayContacts();
                        break;
                    case "3":
                        addressBook.SearchContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        addressBook.EditContact();
                        break;
                    case "6":
                        FileManagement.SaveAddressBookToFile(addressBook, filePath);
                        Console.WriteLine("Address book saved to file.");
                        break;
                    case "7":
                        addressBook = FileManagement.LoadAddressBookFromFile(filePath);
                        Console.WriteLine("Address book loaded from file.");
                        break;
                    case "8":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}

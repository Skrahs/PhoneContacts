using System;
using System.Collections.Generic;

namespace PhoneContacts.Models
{
    public class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Contact newContact = new Contact(name, phoneNumber, email);
            contacts.Add(newContact);

            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("The address book is empty.");
            }
            else
            {
                Console.WriteLine("\n--- Contact List ---");
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void SearchContact()
        {
            Console.Write("Enter the name to search: ");
            string searchedName = Console.ReadLine();

            bool found = false;
            foreach (var contact in contacts)
            {
                if (contact.Name.Equals(searchedName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact found:");
                    Console.WriteLine(contact);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter the name of the contact to delete: ");
            string searchedName = Console.ReadLine();

            Contact contactToRemove = contacts.Find(c => c.Name.Equals(searchedName, StringComparison.OrdinalIgnoreCase));

            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void EditContact()
        {
            Console.Write("Enter the name of the contact to edit: ");
            string searchedName = Console.ReadLine();

            Contact contactToEdit = contacts.Find(c => c.Name.Equals(searchedName, StringComparison.OrdinalIgnoreCase));

            if (contactToEdit != null)
            {
                Console.Write("Enter the new name (leave blank to keep unchanged): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName))
                {
                    contactToEdit.Name = newName;
                }

                Console.Write("Enter the new phone number (leave blank to keep unchanged): ");
                string newPhoneNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPhoneNumber))
                {
                    contactToEdit.PhoneNumber = newPhoneNumber;
                }

                Console.Write("Enter the new email (leave blank to keep unchanged): ");
                string newEmail = Console.ReadLine();
                if (!string.IsNullOrEmpty(newEmail))
                {
                    contactToEdit.Email = newEmail;
                }

                Console.WriteLine("Contact edited successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public void SetContacts(List<Contact> contacts)
        {
            this.contacts = contacts;
        }
    }
}

using Newtonsoft.Json;
using PhoneContacts.Models;
using System.Collections.Generic;
using System.IO;

namespace PhoneContacts.Services
{
    public class FileManagement
    {
        public static void SaveAddressBookToFile(AddressBook addressBook, string filePath)
        {
            var json = JsonConvert.SerializeObject(addressBook.GetContacts(), Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static AddressBook LoadAddressBookFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new AddressBook(); // Return a new address book if the file does not exist
            }

            var json = File.ReadAllText(filePath);
            var contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            AddressBook addressBook = new AddressBook();
            addressBook.SetContacts(contacts);
            return addressBook;
        }
    }
}

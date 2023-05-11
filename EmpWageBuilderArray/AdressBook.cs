using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        // Properties to hold contact details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Constructor to set the contact details
        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class AddressBook
    {
        // Dictionary to hold multiple address books
        private Dictionary<string, List<Contact>> addressBooks;

        // Constructor to initialize the dictionary
        public AddressBook()
        {
            addressBooks = new Dictionary<string, List<Contact>>();
        }

        // Method to add a contact to an address book
        public void AddContact(string addressBookName, Contact contact)
        {
            // If the address book doesn't exist, create it
            if (!addressBooks.ContainsKey(addressBookName))
            {
                addressBooks[addressBookName] = new List<Contact>();
            }

            // Add the contact to the address book
            addressBooks[addressBookName].Add(contact);
        }

        // Method to display all contacts in an address book
        public void DisplayContacts(string addressBookName)
        {
            // If the address book doesn't exist, display an error message
            if (!addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Address book not found.");
                return;
            }

            Console.WriteLine($"Contacts in {addressBookName}:");
            foreach (Contact contact in addressBooks[addressBookName])
            {
                Console.WriteLine("Name: {0} {1}", contact.FirstName, contact.LastName);
                Console.WriteLine("Address: {0}", contact.Address);
                Console.WriteLine("City: {0}", contact.City);
                Console.WriteLine("State: {0}", contact.State);
                Console.WriteLine("Zip: {0}", contact.Zip);
                Console.WriteLine("Phone Number: {0}", contact.PhoneNumber);
                Console.WriteLine("Email: {0}", contact.Email);
                Console.WriteLine();
            }
        }

        // Method to edit a contact's details in an address book
        public bool EditContact(string addressBookName, string firstName, string lastName)
        {
            // If the address book doesn't exist, display an error message
            if (!addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Address book not found.");
                return false;
            }

            // Find the contact to edit
            Contact contact = FindContact(addressBookName, firstName, lastName);
            if (contact != null)
            {
                // Prompt the user to enter the new contact details
                Console.WriteLine("Enter new details for the contact:");

                Console.Write("Enter First Name: ");
                string newFirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string newLastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                string newAddress = Console.ReadLine();

                Console.Write("Enter City: ");
                string newCity = Console.ReadLine();

                Console.Write("Enter State: ");
                string newState = Console.ReadLine();

                Console.Write("Enter Zip: ");
                string newZip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string newPhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                string newEmail = Console.ReadLine();

                // Update the contact details
                contact.FirstName = newFirstName;
                contact.LastName = newLastName;
                contact.Address = newAddress;
                contact.City = newCity;
                contact.State = newState;
                contact.Zip = newZip;
                contact.PhoneNumber = newPhoneNumber;
                contact.Email = newEmail;

                Console.WriteLine("Contact updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }

        // Helper method to find a contact in an address book
        private Contact FindContact(string addressBookName, string firstName, string lastName)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                List<Contact> contacts = addressBooks[addressBookName];
                return contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
            }

            return null;
        }
    }
}
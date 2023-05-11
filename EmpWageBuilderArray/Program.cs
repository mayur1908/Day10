using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageBuilderArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
             empWageBuilderArray.addCompanyEmpWage("DMart", 20, 2, 10);
             empWageBuilderArray.addCompanyEmpWage("Reliance", 20, 50, 60);

             empWageBuilderArray.computeEmpWage();
            */
            Console.WriteLine("WellCome to Adress Book ");

            AddressBook.AddressBook addressBook = new AddressBook.AddressBook();
            // Adding contacts to address books
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Address Book Name: ");
                        string addressBookName = Console.ReadLine();

                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter City: ");
                        string city = Console.ReadLine();

                        Console.Write("Enter State: ");
                        string state = Console.ReadLine();

                        Console.Write("Enter Zip: ");
                        string zip = Console.ReadLine();

                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                        addressBook.AddContact(addressBookName, newContact);
                        Console.WriteLine("Contact added successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Address Book Name: ");
                        string displayAddressBookName = Console.ReadLine();
                        addressBook.DisplayContacts(displayAddressBookName);
                        break;

                    case 3:
                        Console.Write("Enter Address Book Name: ");
                        string editAddressBookName = Console.ReadLine();

                        Console.Write("Enter First Name: ");
                        string editFirstName = Console.ReadLine();

                        Console.Write("Enter Last Name: ");
                        string editLastName = Console.ReadLine();

                        addressBook.EditContact(editAddressBookName, editFirstName, editLastName);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
    }
}

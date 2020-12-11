using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookService addressBookServices = new AddressBookService();
            Console.WriteLine("            Welcome to Address Book          ");
            Console.WriteLine("---------------------------------------------");
            addressBookServices.addContact();
            Console.WriteLine("Enter first name and last name of the person to edit the contact: ");
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            addressBookServices.editContact(firstName, lastName);
        }
    }
}

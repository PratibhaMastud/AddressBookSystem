using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("********* Welcome to Address Book Management System *********");
            AddressBook addressBook = new AddressBook();
            bool ProgramIsRunning = true;
            while (ProgramIsRunning)
            {

                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("#1 Add new user");
                Console.WriteLine("#2 Display user information");
                Console.WriteLine("#3 Edit user information");
                Console.WriteLine("#4 Delete existing user");
                Console.WriteLine("#5 Exit");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        addressBook.addPerson();
                        break;
                    case 2:
                        addressBook.displayPerson();
                        break;
                    case 3:
                        addressBook.editPerson();
                        break;
                    case 4:
                        addressBook.deletePerson();
                        break;
                    case 5:
                        ProgramIsRunning = false;
                        break;
                }
            }
        }
    }
}

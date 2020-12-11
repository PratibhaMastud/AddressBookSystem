using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookService
    {
		Person person = new Person();

		// TO ADD NEW CONTACT
		public void addContact()
		{
			Console.WriteLine("Enter FirstName : ");
			person.setFirstName(Console.ReadLine());
			Console.WriteLine("Enter LastName : ");
			person.setLastName(Console.ReadLine());
			Console.WriteLine("Enter address : ");
			person.setAddress(Console.ReadLine());
			Console.WriteLine("Enter City  : ");
			person.setCity(Console.ReadLine());
			Console.WriteLine("Enter state  : ");
			person.setState(Console.ReadLine());
			Console.WriteLine("Enter Mobile Number  : ");
			person.setPhoneNumber(Console.ReadLine());
			Console.WriteLine("Enter Email Id : ");
			person.setEmail(Console.ReadLine());

			Console.WriteLine(person);
		}
	}
}


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
		public void editContact(String firstName, String lastName)
		{
			if (firstName.Equals(person.getFirstName()) && lastName.Equals(person.getLastName()))
			{
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
				Console.WriteLine("Contact updated successfully\n");
			}
			else
			{
				Console.WriteLine("name not found");
			}
			Console.WriteLine(person);
		}
		public void deleteContact(String firstName, String lastName)
		{
			if (firstName.Equals(person.getFirstName()) && lastName.Equals(person.getLastName()))
			{
				person = null;
				Console.WriteLine("Contact deleted successfully\n");
			}
			else
			{
				Console.WriteLine("name does not exist");
			}

			Console.WriteLine(person);
		}
	}
}


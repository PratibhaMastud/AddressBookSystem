using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Person
    {
		public String firstName;
		public String lastName;
		public String address;
		public String city;
		public String state;
		public String phoneNumber;
		public String email;

		public String getFirstName()
		{
			return firstName;
		}

		public void setFirstName(String firstName)
		{
			this.firstName = firstName;
		}

		public String getLastName()
		{
			return lastName;
		}

		public void setLastName(String lastName)
		{
			this.lastName = lastName;
		}

		public String getAddress()
		{
			return address;
		}

		public void setAddress(String address)
		{
			this.address = address;
		}

		public String getCity()
		{
			return city;
		}

		public void setCity(String city)
		{
			this.city = city;
		}

		public String getState()
		{
			return state;
		}

		public void setState(String state)
		{
			this.state = state;
		}

		public String getPhoneNumber()
		{
			return phoneNumber;
		}

		public void setPhoneNumber(String phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public String getEmail()
		{
			return email;
		}

		public void setEmail(String email)
		{
			this.email = email;
		}

		public override string ToString()
		{
			return string.Format("[{0}, {1}, {2}, {3}, {4}]", firstName, "  ", lastName, "  ", address, "  ", city, "  ", state, "  ", "  ", phoneNumber, "  ", email);
		}

	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
	{
        List<Person> adressBookList;
        public AddressBook()
        {
            this.adressBookList = new List<Person>();
        }
        public void AddContact(string firstName, string lastName, string address, string city, string state, long phoneNumber, string email)
        {
            bool flag = this.adressBookList.Any(item => item.FirstName == firstName && item.LastName == lastName);
            if (!flag)
            {
                Person person = new Person(firstName, lastName, city, state, email, phoneNumber);
                adressBookList.Add(person);
                Console.WriteLine("Contact added Successfully");
            }
            else
            {
                Console.WriteLine("{0}{1} this contact already exist in Address Book :", firstName, lastName);
            }
        }
        public void displayPerson()
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }

        public void displayPersonInOrder()
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            foreach (var person in adressBookList.OrderBy(Key => Key.FirstName))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }

        public void WritePersonDetailTextFile()
        {
            FileReadWrite.WriteTxtFile(adressBookList);
        }

        public void ReadPersonDetailTxtFile()
        {
            FileReadWrite.ReadTxtFile();
        }

        public void WritePersonDetailCsvFile()
        {
            FileReadWrite.writeIntoCsvFile(adressBookList);
        }

        public void ReadPersonDetailCsvFile()
        {
            FileReadWrite.ReadContactsInCSVFile();
        }

        public void WriteContactsInJSONFile()
        {
            FileReadWrite.WriteContactsInJSONFile(adressBookList);
        }

        public void ReadContactsFronJSON()
        {
            FileReadWrite.ReadContactsFromJSONFile();
        }

        public void displayPersonInOrderByCity()
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            foreach (var person in adressBookList.OrderBy(Key => Key.city))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }

        public void displayPersonInOrderByState()
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            foreach (var person in adressBookList.OrderBy(Key => Key.state))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }

        public void searchPerson()
        {
            Console.WriteLine("\n Enter city or state ");
            string city = Console.ReadLine();
            string state = Console.ReadLine();

            foreach (Person person in adressBookList.FindAll(item => item.city == city && item.state == state).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.FirstName, person.LastName);
            }
        }

        public void sameCityPerson()
        {
            Console.WriteLine("\n Enter city for display Same city contacts ");
            string city = Console.ReadLine();
            foreach (Person person in adressBookList.FindAll(item => item.city == city).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.FirstName, person.LastName);
            }
        }

        public void sameStatePerson()
        {
            Console.WriteLine("\n Enter state for display Same State contacts ");
            string stateCheck = Console.ReadLine();
            foreach (Person person in adressBookList.FindAll(item => item.state == stateCheck).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.FirstName, person.LastName);
            }
        }

        public void findCountSameStateOrCityPerson()
        {
            Console.WriteLine("\n Enter city and state");
            string city = Console.ReadLine();
            string state = Console.ReadLine();
            int count2 = 0;
            foreach (Person person in adressBookList.FindAll(item => item.city == city && item.state == state).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.FirstName, person.LastName);
                count2++;
            }
            Console.WriteLine("This {0} persons are in same state {1} \t {2} ", count2, state ,city);
        }
        public void editPerson()
        {
            Console.WriteLine("\n enter First name to edit details:");
            string name = Console.ReadLine();
            foreach (var person in adressBookList)
            {
                if (name.Equals(person.FirstName))
                {
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("#1 Phone Number");
                    Console.WriteLine("#2 Email");
                    Console.WriteLine("#3 City");
                    Console.WriteLine("#4 State");
                    Console.WriteLine("#5 Quit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter new Mobile number:");
                            long mobileNo = Convert.ToInt64(Console.ReadLine());
                            person.setPhoneNumber(mobileNo);
                            Console.WriteLine("mobile no. is updated\n");
                            break;
                        case 2:
                            Console.WriteLine("enter new Email-id:");
                            String email = Console.ReadLine();
                            person.setEmail(email);
                            Console.WriteLine("Email-id is updated\n");
                            break;
                        case 3:
                            Console.WriteLine("enter your city");
                            String city = Console.ReadLine();
                            person.setCity(city);
                            break;
                        case 4:
                            Console.WriteLine("enter your state");
                            String state = Console.ReadLine();
                            person.setState(state);
                            person.setState(state);
                            Console.WriteLine("Address is updated\n");
                            break;
                        default:
                            Console.WriteLine("please enter right choice");
                            break;
                    }
                }
            }
        }

        public void deletePerson()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname of the user you want to remove");
            var lastName = Console.ReadLine();
            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
            /* if (adressBookList.Count > 0)
             {
                 foreach (Person person in adressBookList) 
                 {
                     if (firstName.Equals(person.FirstName))
                     {
                         adressBookList.Remove(person);
                         Console.WriteLine("Contact Deleted{} : ",firstName);
                     }
                 }
             }*/
        }
    }
}



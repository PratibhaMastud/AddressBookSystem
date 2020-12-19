using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class FileReadWrite
    {
        static String FilePath = @"C:\Users\prattii\Desktop\AddBookSysteam\AddressBook\AddressBook\TextFile1.txt";
        static String FilePathCsv = @"C:\Users\prattii\Desktop\AddBookSysteam\AddressBook\AddressBook\ReadWriteCsv.csv";
        public static void WriteTxtFile(List<Person> persons)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePath))
                {
                    foreach (Person person in persons)
                    {
                        streamWriter.WriteLine("FirstName: "+person.FirstName);
                        streamWriter.WriteLine("LastName: " + person.LastName);
                        streamWriter.WriteLine("City    : " + person.city);
                        streamWriter.WriteLine("Email   : " + person.email);
                        streamWriter.WriteLine("State   : " + person.state);
                        streamWriter.WriteLine("PhoneNum: " + person.phoneNumber);
                    }
                    streamWriter.Close();
                }
                Console.WriteLine("Writting Persons detail in to the Text the file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void ReadTxtFile()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader streamReader = File.OpenText(FilePath))
                {
                    String personDetails = "";
                    while ((personDetails = streamReader.ReadLine()) != null)
                        Console.WriteLine((personDetails));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
        /*public static void WriteContactsInCSVFile(List<Person> persons)
        {
            if (File.Exists(FilePathCsv))
            {
                using (StreamWriter streamWriter = new StreamWriter(FilePathCsv))
                {
                    using (CsvWriter csvobj = new CsvWriter(streamWriter, cultureInfo.)) ;
                }
                Console.WriteLine("Writting Contacts to the CSV file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }*/

        public static void writeIntoCsvFile(List<Person> contacts)
        {
            if (File.Exists(FilePathCsv))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePathCsv))
                {
                    foreach (Person contact in contacts)
                    {
                        streamWriter.WriteLine(contact.FirstName + "," + contact.LastName + "," + contact.city + "," + contact.state + "," + contact.phoneNumber);
                    }
                }
            }
        }

        public static void ReadContactsInCSVFile()
        {
            if (File.Exists(FilePathCsv))
            {
                string[] csv = File.ReadAllLines(FilePathCsv);
                foreach (string csValues in csv)
                {
                    string[] column = csValues.Split(",");
                    foreach (string CSValues in column)
                    {
                        Console.WriteLine(CSValues);
                    }
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
    }
}

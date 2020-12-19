using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace AddressBook
{
    class FileReadWrite
    {
        static String FilePath = @"C:\Users\prattii\Desktop\AddBookSysteam\AddressBook\AddressBook\TextFile1.txt";
        static String FilePathCsv = @"C:\Users\prattii\Desktop\AddBookSysteam\AddressBook\AddressBook\ReadWriteCsv.csv";
        static String filePathJson = @"C:\Users\prattii\Desktop\AddBookSysteam\AddressBook\AddressBook\JsonFile.json";

        public static void WriteTxtFile(List<Person> persons)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePath))
                {
                    foreach (Person person in persons)
                    {
                        streamWriter.WriteLine("FirstName: " + person.FirstName);
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
                foreach (string csvValues in csv)
                {
                    string[] column = csvValues.Split(",");
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

        public static void WriteContactsInJSONFile(List<Person> contacts)
        {
            if (File.Exists(filePathJson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePathJson))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Writting Contacts to the JSON file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(filePathJson))
            {
                IList<Person> contactsRead = JsonConvert.DeserializeObject<IList<Person>>(File.ReadAllText(filePathJson));
                foreach (Person contact in contactsRead)
                {
                    Console.Write(contact.ToString());
                }
            }
                else
                {
                    Console.WriteLine("No such file exists");
                }
        }
    }
}

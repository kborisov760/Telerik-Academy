namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    class TextFileToXml
    {
        static void Main()
        {
            var people = new List<Person>();
            string currentLine = string.Empty;
            int peopleCounter = 0;

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                while (!String.IsNullOrEmpty(currentLine = reader.ReadLine()))
                {
                    if (currentLine != null)
                    {
                        var currentPerson = new List<string>();
                        for (int i = 0; i < 3; i++)
                        {
                            currentPerson.Add(currentLine);
                            currentLine = reader.ReadLine();
                        }

                        people.Add(new Person(currentPerson[0], currentPerson[1], currentPerson[2]));
                    }

                    peopleCounter++;
                }
            }
            Console.WriteLine("Task [1]");
            Console.WriteLine("List of people: ");
            Console.WriteLine("------------------");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Task [2]");
            Console.WriteLine("Serializing list of people...");

            XmlSerializer serializedObject = new XmlSerializer(people.GetType());

            using (StreamWriter outputXml = new StreamWriter("../../peopleToXml.xml"))
            {
                serializedObject.Serialize(outputXml, people);
            }

            Console.WriteLine("Serialization completed successfully!");
            Console.WriteLine("----------------------------------");
        }
    }
    
    
}

namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class SongsExtraction
    {
        static void Main()
        {
            var listOfAllSongs = new List<string>();

            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        reader.Read();
                        listOfAllSongs.Add(reader.Value);
                    }
                }
            }

            Console.WriteLine("All songs: {0}", String.Join(", ", listOfAllSongs));
        }
    }
}

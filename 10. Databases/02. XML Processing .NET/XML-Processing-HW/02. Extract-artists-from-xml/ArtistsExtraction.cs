namespace ExtractArtistsFromXML
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ArtistsExtraction
    {
        static void Main()
        {
            XmlDocument calatogDocument = new XmlDocument();
            calatogDocument.Load("../../../catalog.xml");
            XmlNode mainNode = calatogDocument.DocumentElement;
            var allArtists = new Dictionary<string, int>();
            foreach (XmlNode node in mainNode.ChildNodes)
            {
                //allArtists.Add(node["artist"].InnerText, node[]);
                

            }

            var hash = new HashSet<string>();

            Console.WriteLine("List of artists: {0}", String.Join(", ", allArtists));
        }

        //TODO: Implement logic for counting all times given artist's name is matching XML within specific attr

            

        public int CountAuthorAlbums(string artist)
        {
            int artistCounter = 0;

            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while(reader.Read())
                {
                    if((reader.NodeType == XmlNodeType.Element) && (reader.Name == artist))
                    {
                        artistCounter++;
                    }
                }

                reader.Close();
            }
            
            return artistCounter;
        }
    }
}

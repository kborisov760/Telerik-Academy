namespace XMLProcessing
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

            var allArtists = new HashSet<string>();
            var artistsHashSet = new HashSet<string>();

            foreach (XmlNode node in mainNode.ChildNodes)
            {
                allArtists.Add(node["artist"].InnerText);
            }

            Console.WriteLine("List of artists: {0}", String.Join(", ", allArtists));
            Console.WriteLine("-------------------");
            Console.WriteLine("Number of albums for every artist: ");

            foreach (XmlNode currentNode in mainNode.ChildNodes)
            {
                foreach(XmlNode innerNode in currentNode)
                {
                    if (innerNode.Name == "artist" && !artistsHashSet.Contains(innerNode.InnerText))
                    {
                        
                        artistsHashSet.Add(innerNode.InnerText);
                        Console.WriteLine("{0} has {1} album(s).", innerNode.InnerText, CountAuthorAlbums(innerNode.InnerText));
                    }
                }
                
            }
            
        }   
         
        static int CountAuthorAlbums(string artist)
        {
            int currentArtistCounter = 0;

            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while(reader.Read())
                {
                    if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
                    {
                        reader.Read();
                        if (reader.Value == artist)
                        {
                            currentArtistCounter++;
                        }
                    }
                }

                reader.Close();
            }
            
            return currentArtistCounter;
        }
    }
}

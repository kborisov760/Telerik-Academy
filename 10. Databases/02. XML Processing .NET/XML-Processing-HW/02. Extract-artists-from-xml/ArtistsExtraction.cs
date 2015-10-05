namespace ExtractArtistsFromXML
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Linq;

    class ArtistsExtraction
    {
        static void Main()
        {
            XmlDocument calatogDocument = new XmlDocument();
            calatogDocument.Load("../../../catalog.xml");
            XmlNode mainNode = calatogDocument.DocumentElement;
            var allArtists = new List<string>();


            foreach (XmlNode node in mainNode.ChildNodes)
            {
                allArtists.Add(node["artist"].InnerText);
            }

            Console.WriteLine("List of artists: {0}", String.Join(", ", allArtists));
            Console.WriteLine();
            Console.WriteLine("Number of albums for every artist: ");
            Console.WriteLine("------------------");
            Console.WriteLine();

            var artistsHashSet = new HashSet<string>();

            //foreach (XmlNode node in mainNode.ChildNodes)
            //{
            //    foreach(XmlNode s in node)
            //    {
            //        Console.WriteLine(s.Name);
            //    }
            //}

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

            Console.WriteLine();
            
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

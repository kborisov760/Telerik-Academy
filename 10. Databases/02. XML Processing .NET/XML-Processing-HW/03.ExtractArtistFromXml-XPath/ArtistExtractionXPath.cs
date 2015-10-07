namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    public class ArtistExtractionXPath
    {
        static void Main()
        {
            XmlDocument calatogDocument = new XmlDocument();
            calatogDocument.Load("../../../catalog.xml");
            string xPathQuery = "/catalog/album/artist";
            XmlNodeList artistList = calatogDocument.SelectNodes(xPathQuery);

            var allArtists = new HashSet<string>();
            var artistHashSet = new HashSet<string>();

            for (int i = 0; i < artistList.Count; i++)
            {
                allArtists.Add(artistList[i].InnerText);
            }

            Console.WriteLine("List of artists: {0}", String.Join(", ", allArtists));
            Console.WriteLine("-------------------");
            Console.WriteLine("Number of albums for every artist: ");
            
              string xPathQuerySecondSelection = "/catalog/album";

            XmlNodeList wholeDocument = calatogDocument.SelectNodes(xPathQuerySecondSelection);

            for (int i = 0; i < wholeDocument.Count; i++)
            {
                var currentNode = wholeDocument[i];

                if(currentNode.Name == "album")
                {
                    //TODO: Logic for getting inner nodes
                    XmlNodeList innerDocumentContent = currentNode.ChildNodes;
                    for (int j = 0; j < innerDocumentContent.Count; j++)
                    {
                        var currentInnerNode = innerDocumentContent[j];
                        if (currentInnerNode.Name == "artist" && !artistHashSet.Contains(currentInnerNode.InnerText))
                        {
                            artistHashSet.Add(currentInnerNode.InnerText);
                            Console.WriteLine("{0} has {1} albums(s).", currentInnerNode.InnerText, CountAuthorAlbums(currentInnerNode.InnerText));
                        }
                    }
                    
                }

                
            }

            //foreach (XmlNode currentNode in wholeDocument)
            //{
            //    if(currentNode.Name == "artist" && !artistHashSet.Contains(currentNode.InnerText))
            //    {
            //        artistHashSet.Add(currentNode.InnerText);
            //        Console.WriteLine("{0} has {1} albums(s).", currentNode.InnerText, CountAuthorAlbums(currentNode.InnerText));
            //    }
            //}

            
        }

        public static int CountAuthorAlbums(string artist)
        {
            int currentArtistCounter = 0;

            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
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
namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class SongExtractionLINQ
    {
        static void Main()
        {
            XDocument albumCatalog = XDocument.Load("../../../catalog.xml");
            var songsSelection =
                from song in albumCatalog.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value,
                    Duration = song.Element("duration").Value
                };

            Console.WriteLine("All songs: {0}", songsSelection.Count());
            Console.WriteLine();
            foreach (var song in songsSelection)
            {
                Console.WriteLine("Title: {0}", song.Title);
                Console.WriteLine("Duration: {0}", song.Duration);
                Console.WriteLine();
            }


        }
    }
}

namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class DeleteDOMParser
    {
        static void Main()
        {
            XmlDocument calatogDocument = new XmlDocument();
            calatogDocument.Load("../../../catalog.xml");
            XmlNode mainNode = calatogDocument.DocumentElement;

            foreach (XmlNode childNodes in mainNode.ChildNodes)
            {
                if(childNodes.Name == "album")
                {
                    foreach (var child in childNodes.ChildNodes)
                    {
                        //TODO: Implement logic for search and delete
                    }
                }
            }
        }
    }
}

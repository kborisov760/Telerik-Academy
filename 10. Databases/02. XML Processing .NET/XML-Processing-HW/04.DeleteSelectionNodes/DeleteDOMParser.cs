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
                    var currentNode = childNodes;
                    foreach (XmlNode child in childNodes.ChildNodes)
                    {
                        //TODO: Implement logic for search and delete
                        if (child.Name == "price" && child.Attributes[0].Value == "gt")
                        {
                            mainNode.RemoveChild(currentNode);
                            Console.WriteLine("XML Node removed successfully!");
                            calatogDocument.Save("../../../catalogEdit.xml");
                            Console.WriteLine("Document with changes saved successfully!");
                        }
                    }
                }
            }
        }
    }
}

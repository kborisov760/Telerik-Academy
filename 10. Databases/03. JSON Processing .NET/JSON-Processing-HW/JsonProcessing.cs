namespace JsonProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Web;
    using System.Web.Script.Serialization;

    class JsonProcessing
    {
        static void Main()
        {
            WebClient xmlFeed = new WebClient();
            xmlFeed.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var xmlFeedToJson = serializer.Serialize(xmlFeed);

            Console.WriteLine(xmlFeedToJson);
        }
    }
}

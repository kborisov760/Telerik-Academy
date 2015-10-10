namespace JsonProcessing
{
    using System;
    using System.Net;
    using System.Xml.Linq;
    using System.Web;
    using System.Web.Script.Serialization;
    using Newtonsoft.Json;
    using System.Xml;
    using Newtonsoft.Json.Linq;
    using System.Linq;
    using System.IO;

    class JsonProcessing
    {
        static void Main()
        {
            var webclient = new WebClient();
            webclient.DownloadFile(
                "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw",
                "../../rss.xml");
            XDocument rss = XDocument.Load("../../rss.xml");
            string jsonFromXml = JsonConvert.SerializeXNode(rss, Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFromXml);
            var titles = jsonObj["feed"]["entry"].Select(entry => entry["title"]);
            Console.WriteLine("Titles of the videos:\n");
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            var template = new { id = string.Empty, title = string.Empty, published = string.Empty };
            var videos = jsonObj["feed"]["entry"].Select(video => JsonConvert.DeserializeAnonymousType(video.ToString(), template));
            var htmlCreator = new StreamWriter("../../videos.html");
            htmlCreator.Write("<html><head><title>Videos from Telerik RSS</title><meta charset=\"UTF-8\"></head><body>");
            foreach (var video in videos)
            {
                htmlCreator.WriteLine(
                    "<div style=\"display: inline-block;\"><iframe width=420 height=315 src=\"https://www.youtube.com/embed/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\"></iframe><br />"
                    + "<a style=\"text-decoration: none; font-family: Arial; color: #444;\""
                    + " href=\"https://youtu.be/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\" target=\"_blank\">" + video.title + "</a></div"
                    + ">");
            }

            htmlCreator.Write("</body></html>");
            htmlCreator.Close();
        }
    }
}

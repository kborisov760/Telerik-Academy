namespace HttpHandler
{
    using System;
    using System.Web;

    public class GetPostCustomHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image";

            if (context.Request.RequestType == "GET")
            {
                context.Response.WriteFile("images/get.png");
            }
            else if (context.Request.RequestType == "POST")
            {
                context.Response.WriteFile("images/post.png");
            }
            else
            {
                context.Response.ContentType = "text/html";
                context.Response.Write("You cannot do that request.");
                context.Response.StatusCode = 403;
            }
        }
    }
}
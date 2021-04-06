using API.BL;
using System.Net;
using System.IO;

namespace API.Service
{
    /// <summary>
    /// Сервис принимающий веб строку 
    /// </summary>
    public class PageService : IPageService
    {
        public string GetString(string page)
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead(page);

            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();

            ParseWebUrl.ConvertHtml(s);

            
            return page;
        }
    }
}

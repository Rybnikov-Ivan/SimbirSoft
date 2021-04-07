using API.BL;
using System.Net;
using System.IO;
using System;

namespace API.Service
{
    /// <summary>
    /// Сервис принимающий веб строку 
    /// </summary>
    public class PageService : IPageService
    {
        public void GetString(string page)
        {
            WebRequest webRequest = HttpWebRequest.Create(page);
            webRequest.Method = "HEAD";
            try
            {
                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    Console.WriteLine("Exists");
                }
            }
            catch (WebException ex)
            {
                throw new ArgumentException("Not exists: " + ex.Message);
            }

            WebClient client = new WebClient();           
            Stream data = client.OpenRead(page);

            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();

            ParseWebUrl.ConvertHtml(s);
        }
    }
}

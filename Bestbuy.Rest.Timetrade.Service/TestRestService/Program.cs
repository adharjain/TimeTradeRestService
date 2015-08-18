using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestRestService
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    string content;
                    Console.WriteLine("Enter Method:");
                    string Method = Console.ReadLine();

                    Console.WriteLine("Enter URI:");
                    string uri = Console.ReadLine();

                    HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
                    req.KeepAlive = false;
                    req.Method = Method.ToUpper();

                    if (("POST,PUT").Split(',').Contains(Method.ToUpper()))
                    {
                        Console.WriteLine("Enter XML FilePath:");
                        string FilePath = Console.ReadLine();
                        content = (File.OpenText(@FilePath)).ReadToEnd();

                        byte[] buffer = Encoding.ASCII.GetBytes(content);
                        req.ContentLength = buffer.Length;
                        req.ContentType = "text/xml";
                        Stream PostData = req.GetRequestStream();
                        PostData.Write(buffer, 0, buffer.Length);
                        PostData.Close();
                    }

                    HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

                    Encoding enc = System.Text.Encoding.GetEncoding(1252);
                    StreamReader loResponseStream =
                    new StreamReader(resp.GetResponseStream(), enc);

                    string Response = loResponseStream.ReadToEnd();

                    loResponseStream.Close();
                    resp.Close();
                    Console.WriteLine(Response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue?");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}

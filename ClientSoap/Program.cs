using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSoap.ServiceReference1;

namespace ClientSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            UrlWebServiceClient client = new UrlWebServiceClient();
            Console.WriteLine("URLS GENERADOS PARA EL USUARIO 1");
            ShowurlsAsync(client);
            Console.ReadKey();
        }

        private static void ShowurlsAsync(UrlWebServiceClient WebServiceClient)
        {
            var s = WebServiceClient.getUrl(1);
            foreach (var item in s)
            {
                Console.WriteLine(item.url + "--> " + item.redirect);
            }
        }
    }
}

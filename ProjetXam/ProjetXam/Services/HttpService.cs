using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProjetXam.Services
{
    public static class HttpService
    {
        static HttpClient client;

        public static HttpClient getInstance()
        {
            if(client == null)
            {
                client = new HttpClient();
            }
            return client;
        }
    }
}

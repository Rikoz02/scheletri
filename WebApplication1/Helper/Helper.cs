using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace WebApplication1
{
    public class Helper
    {
        public class StudentAPI
        {
            public HttpClient Initial()
            {
                var Client = new HttpClient();
                Client.BaseAddress = new Uri("http://localhost:58017");
                return Client;
            }
        }
    }
}

using System;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ConsoleApplication 
{
    public class Funkr
    {

        private static String JAMBASE_BASE_URL = "http://api.jambase.com/";

        private string _API_KEY;
        public String API_KEY 
        {
            get { return _API_KEY; }
            set { _API_KEY = value; }
        }

        public void PingJamBase()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(JAMBASE_BASE_URL);

            // add an accept Header
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            String urlParameters = "events?id=1930726&api_key=";

            // list data response
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if(response.IsSuccessStatusCode) 
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                foreach( var d in dataObjects )
                {
                    Console.WriteLine("{0}", d.ToString());
                }
            }
            else 
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }
    }
}
using System.Net.Http;

namespace ServerSideRequestForgery
{
    public class Ssrf
    {
        public string HttpClientAsync(string host)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://" + host + "/api/discover");
            return response;
            
        }
    }
}
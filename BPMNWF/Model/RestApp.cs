using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model
{
    public class RestApp
    {
        //private byte[] authenticationByte = Encoding.ASCII.GetBytes("kermit:kermit");

        private static string address = "http://192.168.99.100:8080/";
        public HttpClient httpClient { get; }
        public RestApp(String username, String password)
        {
            byte[] authenticationByte = Encoding.ASCII.GetBytes(username + ':' + password);

            httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authenticationByte));
        }

        public string makeGet(string url)
        {
            var response = httpClient.GetStringAsync(address + url);

            try
            {
                return response.Result;
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.ToString());
                return "";
            }
        }

        public bool makePost(string url, StringContent stringContent)
        {
            return httpClient.PostAsync(address + url, stringContent).Result.IsSuccessStatusCode;
        }

        public bool makeDelete(string url)
        {
            return httpClient.DeleteAsync(address + url).Result.IsSuccessStatusCode;
        }

        //public async void test(string url)
        //{
        //    var test = await httpClient.GetAsync(address + url);
        //    Console.WriteLine(test.StatusCode);
        //}
        
    }
}

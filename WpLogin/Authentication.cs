using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AscentRestApi;

namespace WpLogin
{
    public class Authentication
    {
        Token tokenRequest;
        public async void LoginToWordpress(string userName, string password)
        {
            using (RestApi.client = new HttpClient())
            {
                var values = new Dictionary<string, string>
            {
                { "username", userName },
                { "password", password }
            };

                string url = RestApi.baseAddress + RestApi.jwtToken;
                var data = new FormUrlEncodedContent(values);
                var response = await RestApi.client.PostAsync(url, data);
                if (RestApi.IsConnected(response))
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    tokenRequest = JsonConvert.DeserializeObject<Token>(responseString);
                    RestApi.client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenRequest.token);
                }
                
            }
        }
    }
}

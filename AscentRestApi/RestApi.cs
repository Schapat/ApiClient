using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AscentRestApi
{
    public class RestApi
    {
        public HttpClient client;
        private Token tokenRequest;
        private String username;
        private String password;
        private HttpResponseMessage tokenResponse;
        private HttpResponseMessage proConfigResponse;

        public static string baseAddress = "http://127.0.0.1/wordpress/";
        //Validation 
        private static string jsonAddress = "wp-json";
        private static string jwtAuth = jsonAddress + "/jwt-auth/v1";
        public static string jwtToken = jwtAuth + "/token";
        public static string jwtTokenValidate = jwtToken + "/validate";
        //csgo Pro Config
        private static string csgoAddress = jsonAddress + "/csgo/v1";
        public static string proConfigAdress = csgoAddress + "/pro_config";


        public RestApi(String username, String password)
        {
            this.username = username;
            this.password = password;
            client = new HttpClient();
        }

        private bool IsConnected(HttpResponseMessage response)
        {
           return response.IsSuccessStatusCode;
        }

        public async Task<List<ProConfig>> GetProConfig()
        {
            string url = RestApi.baseAddress + RestApi.proConfigAdress;
            proConfigResponse = await client.GetAsync(url);
            if (IsConnected(proConfigResponse))
            {
                var responseString = await proConfigResponse.Content.ReadAsStringAsync();
                var proConfigs = JsonConvert.DeserializeObject<List<ProConfig>>(responseString);
                return proConfigs;
            }
            return null;
        }

        public async void TokenRequest()
        {
            var values = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            string url = baseAddress + jwtToken;
            var data = new FormUrlEncodedContent(values);
            this.tokenResponse = await client.PostAsync(url, data);
        }

        public async void SetLoginToken()
        {
            if (IsConnected(tokenResponse))
            {
                var responseString = await tokenResponse.Content.ReadAsStringAsync();
                tokenRequest = JsonConvert.DeserializeObject<Token>(responseString);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenRequest.token);
            }
        }
    }
}

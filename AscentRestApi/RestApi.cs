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
        private HttpResponseMessage tokenResponse;
        private HttpResponseMessage proConfigResponse;
        public bool IsAuthenticated = false;

        public static string baseAddress = "http://127.0.0.1/wordpress/";
        //Validation 
        private static string jsonAddress = "wp-json";
        private static string jwtAuth = jsonAddress + "/jwt-auth/v1";
        public static string jwtToken = jwtAuth + "/token";
        public static string jwtTokenValidate = jwtToken + "/validate";
        //csgo Pro Config
        private static string csgoAddress = jsonAddress + "/csgo/v1";
        public static string proConfigAdress = csgoAddress + "/pro_config";

        public RestApi()
        {
            client = new HttpClient();
        }

        private bool IsConnected(HttpResponseMessage response)
        {
           return response.IsSuccessStatusCode;
        }

        public async Task<List<ProConfig>>ProConfigRequest()
        {
            string url = baseAddress + proConfigAdress;
            proConfigResponse = await client.GetAsync(url);
            if (IsConnected(proConfigResponse))
            {
                var responseString = await proConfigResponse.Content.ReadAsStringAsync();
                var proConfigs = JsonConvert.DeserializeObject<List<ProConfig>>(responseString);
                return proConfigs;
            }
            return null;
        }

        private async Task TokenRequest(string username, string password)
        {
            var values = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            string url = baseAddress + jwtToken;
            var data = new FormUrlEncodedContent(values);
            tokenResponse = await client.PostAsync(url, data);
        }

        private async Task SetLoginToken()
        {
            if (IsConnected(tokenResponse))
            {
                var responseString = await tokenResponse.Content.ReadAsStringAsync();
                tokenRequest = JsonConvert.DeserializeObject<Token>(responseString);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenRequest.token);
                IsAuthenticated = true;
            }
        }
        public async Task Login(string username, string password)
        {
            await TokenRequest(username, password);
            await SetLoginToken();
        }
    }
}

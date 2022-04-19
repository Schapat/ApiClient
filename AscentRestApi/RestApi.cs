using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AscentRestApi
{
    public class RestApi
    {
        public static HttpClient client;

        public static string baseAddress = "http://127.0.0.1/wordpress/";
        //Validation 
        private static string jsonAddress = "wp-json";
        private static string jwtAuth = jsonAddress + "/jwt-auth/v1";
        public static string jwtToken = jwtAuth + "/token";
        public static string jwtTokenValidate = jwtToken + "/validate";
        //csgo Pro Config
        private static string csgoAddress = jsonAddress + "/csgo/v1";
        public static string proConfigAdress = csgoAddress + "/pro_config";


        public static bool IsConnected(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode) return true;
            return false;
        }
    }
}

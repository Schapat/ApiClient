using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AscentRestApi;

namespace ProConfigLoader
{
    public class ProConfigRequest
    {
        public async Task<List<ProConfig>> GetProConfig()
        {
            ProConfig proConfig;
            List<ProConfig> proConfigList = new List<ProConfig>();
            //Hier muss nachher der Login token uebergeben werden
            using (RestApi.client = new HttpClient())
            {

                string url = RestApi.baseAddress + RestApi.proConfigAdress;
                var response = await RestApi.client.GetAsync(url);
                if (RestApi.IsConnected(response))
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var proConfigs = JsonConvert.DeserializeObject<List<ProConfig>>(responseString);

                    foreach (var config in proConfigs)
                    {
                        proConfig = new ProConfig();
                        proConfig.pro_id = config.pro_id;
                        proConfig.pro_name = config.pro_name;
                        proConfig.config = config.config;
                        proConfig.autoexec = config.autoexec;
                        proConfig.video = config.video;
                        proConfigList.Add(proConfig);

                    }
                    return proConfigs;
                }
            }
            return null;
        }
    }
}

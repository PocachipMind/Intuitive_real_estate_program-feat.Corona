using CoronaTrace.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrace.ViewModel
{
    public class HouseAPI
    {
        public static HouseInformation GetHouseInformation(int HouseID)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            HouseInformation result = new HouseInformation();
            string ID = HouseID.ToString();
            string url = "https://apis.zigbang.com/v2/items/" + ID;

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url);
                string json = response.Result.Content.ReadAsStringAsync().Result;

                result = JsonConvert.DeserializeObject<HouseInformation>(json);
            }

            return result;
        }
    }
}

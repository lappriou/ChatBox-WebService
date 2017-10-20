using ChatBot.PCL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Dashboard.Utils
{
    public class RaclettePollService
    {
        #region Singleton
        private static RaclettePollService instance;

        private RaclettePollService() { }

        public static RaclettePollService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RaclettePollService();
                }
                return instance;
            }
        }
        #endregion
        public async Task<IEnumerable<RaclettePoll>> GetAsync()
        {
            var json = await GetJson("/api/RaclettePolls");
            var result = JsonConvert.DeserializeObject<IEnumerable<RaclettePoll>>(json);
            return result;
        }





        public async Task<string> GetJson(string api)
        {
            string result;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://backwebservice.azurewebsites.net");
                var response = await client.GetAsync(api);
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}


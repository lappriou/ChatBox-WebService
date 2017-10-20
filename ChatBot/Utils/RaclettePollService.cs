using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;

namespace ChatBot.Utils
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

        public async Task SendBddAsync(string clientApp, string user, bool like, string favorite)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://backwebservice.azurewebsites.net");
                var result = await client.PostAsync("/api/RaclettePolls", new
                {
                    Favorite = favorite,
                    User = user,
                    Client = clientApp,
                    Date = DateTime.Now,
                    Like = like
                }, new JsonMediaTypeFormatter());
            }
        }

    }
}
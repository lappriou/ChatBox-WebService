using ChatBot.PCL;
using Dashboard.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dashboard.ViewModels.Home
{
    public class ListPollViewModel
    {
        public IEnumerable<RaclettePoll> RaclettePollsList { get; set; }
        public async Task InitRacletteListAsync()
        {
            var list = await RaclettePollService.Instance.GetAsync();
            RaclettePollsList = list.ToList();
            foreach(var item in RaclettePollsList)
            {
                item.Favorite = item.Favorite.Replace("_", " ");
            }

        }
    }
}
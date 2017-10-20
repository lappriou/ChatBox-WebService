using ChatBot.PCL;
using Dashboard.Models.Component_HTML;
using Dashboard.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dashboard.ViewModels.Home
{
    public class IndexViewModel
    {
        public float PercentGoal { get; set; }
        public List<RaclettePoll> RaclettePollsList { get; set; }
        public float MinNumber { get; set; }
        public List<CardElement> ListCards { get; set; }

        public IndexViewModel()
        {
            
        }

        public async Task InitAsync()
        {

            MinNumber = 10;

            await InitRacletteListAsync();

            await InitListCardAsync();

            PercentGoal = RaclettePollsList.Count / MinNumber;
            PercentGoal *= 100;
        }

        public async Task InitRacletteListAsync()
        {
            var list = await RaclettePollService.Instance.GetAsync();
            RaclettePollsList = list.ToList();
            foreach (var item in RaclettePollsList)
            {
                item.Favorite = item.Favorite.Replace("_", " ");
            }

        }

        public async Task InitListCardAsync()
        {
          


            ListCards = new List<CardElement>();
            ListCards.Add(await InitCardLike());
            ListCards.Add(await InitCardFavorite());
            ListCards.Add(await InitCardClient());

        }
        public async Task<CardElement> InitCardFavorite()
        {

            var card = new CardElement();
            card.Title = "Les tops raclettes";
            card.NumberResult = new List<FieldElement>();
            foreach(var item in RaclettePollsList)
            {
                if(card.NumberResult.Count(p=> p.Key == item.Favorite) == 0)
                {
                    card.NumberResult.Add(new FieldElement() { Key = item.Favorite, Value = 1, Color = ColorsUtils.Instance.GetRandomColor()});
                }
                else
                {
                    card.NumberResult.Find(p=> p.Key == item.Favorite).Value += 1;
                }
            }
            card.NumberResult = card.NumberResult.OrderByDescending(p => p.Value).Select(d => d).ToList();
            card.GraphResult = new GraphPie(card.NumberResult);
            return card;
        }
        public async Task<CardElement> InitCardClient()
        {

            var card = new CardElement();
            card.Title = "Les tops clients";
            card.NumberResult = new List<FieldElement>();
            foreach (var item in RaclettePollsList)
            {
                if (card.NumberResult.Count(p => p.Key == item.Client) == 0)
                {
                    card.NumberResult.Add(new FieldElement() { Key = item.Client, Value = 1, Color = ColorsUtils.Instance.GetRandomColor() });
                }
                else
                {
                    card.NumberResult.Find(p => p.Key == item.Client).Value += 1;
                }
            }
            card.NumberResult = card.NumberResult.OrderByDescending(p => p.Value).Select(d => d).ToList();
            card.GraphResult = new GraphPie(card.NumberResult);
            return card;
        }


        public async Task<CardElement> InitCardLike()
        {

            var card = new CardElement();
            card.Title = "Amour pour la raclette";
            card.NumberResult = new List<FieldElement>();
            foreach (var item in RaclettePollsList)
            {

                var temp = item.Like ? "Oui" : "Non";

                if (card.NumberResult.Count(p => p.Key == temp) == 0)
                {
                    card.NumberResult.Add(new FieldElement() { Key = temp, Value = 1, Color = ColorsUtils.Instance.GetRandomColor() });
                }
                else
                {
                    card.NumberResult.Find(p => p.Key == temp).Value += 1;
                }
            }
            card.NumberResult = card.NumberResult.OrderByDescending(p => p.Value).Select(d => d).ToList();

            card.GraphResult = new GraphPie(card.NumberResult);
            return card;
        }

    }
}

using ChatBot.Utils;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ChatBot.Forms
{
    [Serializable]
    public class PollRacletteForm
    {
        public Answer Like { get; set; }
        public RacletteName RacletteFavorite { get; set; }

      
        public static IForm<PollRacletteForm> BuildForm()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            return new FormBuilder<PollRacletteForm>()
                .Message("Bonjour")
                .Message("Vous aimez la raclette ? ")
                 .OnCompletion(async (context, profileForm) =>
                 {
                     bool like = profileForm.Like.ToString() == "Oui" ? true : false;
                     await RaclettePollService.Instance.SendBddAsync(context.Activity.ChannelId, context.Activity.From.Name,like, profileForm.RacletteFavorite.ToString());
                     // Tell the user that the form is complete
                     await context.PostAsync("Merci d'avoir répondu a ce petit sondage");
                 })
                .Build();
        }


        
    }

    [Serializable]
    public enum Answer
    {
        Oui = 1, Non = 2
    }
    [Serializable]
    public enum RacletteName
    {
        Gratin_de_brocoli_au_fromage_à_raclette = 1,
        Gratin_dendives_à_la_savoyarde = 2,
        Nid_de_montagne = 3,
        Pain_de_thon_et_sa_salade = 4,
        Patachée = 5,
        Pizza_raclette_bacon_et_fromage_frais_de_Léa = 6,
        Salade_composée_pommes_de_terre_asperge_raclette = 7,
        Salade_pomme_de_terre_knackies = 8
    }

}
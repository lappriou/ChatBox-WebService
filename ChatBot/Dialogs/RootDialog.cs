using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Linq;
using System.Text.RegularExpressions;
using ChatBot.Forms;
using Microsoft.Bot.Builder.FormFlow;
using System.Threading;
using System.Globalization;

namespace ChatBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        private PollRacletteForm pollRaclette;
        public async Task StartAsync(IDialogContext context)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            context.Wait(MessageReceivedAsync);
        }


        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            var activity = await result as Activity;
            context.Wait(MessageReceivedAsync);
        }
    }
}
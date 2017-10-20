using System;
using Dashboard.ViewModels.Home;
using Dashboard.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using ChatBot.PCL;
using System.Drawing;
using Dashboard.Models.Component_HTML;
using BackAPI.Controllers;
using System.Web.Mvc;
using System.Linq;
using System.Web.Http;
using ChatBot.Forms;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;

namespace ChatBot.TU
{
    [TestClass]
    public class UnitTest1
    {
        //Test RaclettePollService - function GetJson()
        [TestMethod]
        public async Task TestMethodGetJson1()
        {
            var result = await RaclettePollService.Instance.GetJson("/api/RaclettePolls");
            Assert.IsInstanceOfType(result, typeof(string));
        }
        [TestMethod]
        public async Task TestMethodGetJson1_1()
        {
            string result = await RaclettePollService.Instance.GetJson("/api/RaclettePolls");
            Assert.IsNotNull(result);
        }

        //Test RaclettePollService - function GetAsync()
        [TestMethod]
        public async Task TestMethodGetAsync1()
        {
            IEnumerable<RaclettePoll> result = await RaclettePollService.Instance.GetAsync();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public async Task TestMethodGetAsync1_1()
        {
            IEnumerable<RaclettePoll> result = await RaclettePollService.Instance.GetAsync();
            Assert.IsInstanceOfType(result, typeof(IEnumerable<RaclettePoll>));
        }

        //Test IndexViewModel - function GetRandomColor()
        [TestMethod]
        public void TestMethodGetRandomColor1()
        {
            Assert.IsNotNull(ColorsUtils.Instance.GetRandomColor());
        }
        [TestMethod]
        public void TestMethodGetRandomColor1_1()
        {
            Assert.IsInstanceOfType(ColorsUtils.Instance.GetRandomColor(), typeof(Color));
        }

        //Test IndexViewModel - function InitCardFavorite()
        [TestMethod]
        public async Task TestMethodInitCardFavorite1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsNotNull(await unindex.InitCardFavorite());
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsInstanceOfType(await unindex.InitCardFavorite(),typeof(CardElement));
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsNotNull(card.Title);
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_1_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsInstanceOfType(card.Title, typeof(string));
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_2_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsNotNull(card.NumberResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_2_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsInstanceOfType(card.NumberResult, typeof(List<FieldElement>));
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_3_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsNotNull(card.GraphResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardFavorite1_2_3_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardFavorite();
            Assert.IsInstanceOfType(card.GraphResult, typeof(GraphPie));
        }


        //Test IndexViewModel - function InitCardClient()
        [TestMethod]
        public async Task TestMethodInitCardClient1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsNotNull(await unindex.InitCardClient());
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsInstanceOfType(await unindex.InitCardClient(), typeof(CardElement));
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsNotNull(card.Title);
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_1_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsInstanceOfType(card.Title, typeof(string));
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_2_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsNotNull(card.NumberResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_2_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsInstanceOfType(card.NumberResult, typeof(List<FieldElement>));
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_3_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsNotNull(card.GraphResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardClient1_2_3_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardClient();
            Assert.IsInstanceOfType(card.GraphResult, typeof(GraphPie));
        }



        //Test IndexViewModel - function InitCardLike()
        [TestMethod]
        public async Task TestMethodInitCardLike1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsNotNull(await unindex.InitCardLike());
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            Assert.IsInstanceOfType(await unindex.InitCardLike(), typeof(CardElement));
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_1_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsNotNull(card.Title);
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_1_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsInstanceOfType(card.Title, typeof(string));
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_2_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsNotNull(card.NumberResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_2_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsInstanceOfType(card.NumberResult, typeof(List<FieldElement>));
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_3_1()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsNotNull(card.GraphResult);
        }
        [TestMethod]
        public async Task TestMethodInitCardLike1_2_3_2()
        {
            IndexViewModel unindex = new IndexViewModel();
            await unindex.InitAsync();
            CardElement card = await unindex.InitCardLike();
            Assert.IsInstanceOfType(card.GraphResult, typeof(GraphPie));
        }

        //Test HomeController - function Index()
        [TestMethod]
        public void TestMethodIndex1()
        {
            HomeController controller = new HomeController();
            ActionResult result;
            result = controller.Index();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodIndex1_1()
        {
            HomeController controller = new HomeController();
            ActionResult result;
            result = controller.Index();
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        //Test RaclettePollsController - function GetRaclettePolls
        [TestMethod]
        public void TestMethodGetRaclettePolls1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            IQueryable<RaclettePoll> result = controller.GetRaclettePolls();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodGetRaclettePolls1_1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            IQueryable<RaclettePoll> result = controller.GetRaclettePolls();
            Assert.IsInstanceOfType(result, typeof(IQueryable<RaclettePoll>));
        }

        //Test RaclettePollsController - function GetRaclettePoll
        /**
         * exception: string named in function ('BackApiContext' in db.RaclettePolls.Find(id))
        [TestMethod]
        public void TestMethodGetRaclettePoll1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            int id = 1;
            IHttpActionResult result = controller.GetRaclettePoll(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodGetRaclettePoll1_1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            int id = 1;
            IHttpActionResult result = controller.GetRaclettePoll(id);
            Assert.IsInstanceOfType(result, typeof(IHttpActionResult));
        }*/

        //Test RaclettePollsController - function PutRaclettePoll
        [TestMethod]
        public void TestMethodPutRaclettePoll1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            RaclettePoll racpoll = new RaclettePoll();
            IHttpActionResult result = controller.PutRaclettePoll(1, racpoll);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodPutRaclettePoll1_1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            RaclettePoll racpoll = new RaclettePoll();
            IHttpActionResult result = controller.PutRaclettePoll(1, racpoll);
            Assert.IsInstanceOfType(result, typeof(IHttpActionResult));
        }

        /**
         * exception: string named in function ('BackApiContext' in db.RaclettePolls.Add(raclettePoll))
        //Test RaclettePollsController - function PutRaclettePoll
        [TestMethod]
        public void TestMethodPostRaclettePoll1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            RaclettePoll racpoll = new RaclettePoll();
            IHttpActionResult result = controller.PostRaclettePoll(racpoll);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodPostRaclettePoll1_1()
        {
            RaclettePollsController controller = new RaclettePollsController();
            RaclettePoll racpoll = new RaclettePoll();
            IHttpActionResult result = controller.PostRaclettePoll(racpoll);
            Assert.IsInstanceOfType(result, typeof(IHttpActionResult));
        }*/
        //Same for Delete

        //Test ValuesController - function Get()
        [TestMethod]
        public void TestMethodGet1()
        {
            Assert.IsNotNull(PollRacletteForm.BuildForm());
        }
        [TestMethod]
        public void TestMethodGet1_1()
        {
            Assert.IsInstanceOfType(PollRacletteForm.BuildForm(), typeof(IForm<PollRacletteForm>));
        }


    }
}

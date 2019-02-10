using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using webAPI.webAPI.Api.Models;
using Newtonsoft.Json;

namespace webAPI.webAPI.Api.Controllers
{
    public class NbaController : ApiController
    {
        // GET: api/Nba
        public IHttpActionResult GetCardList()
        {
            var cards = new List<NbaCard>()
            {

                new NbaCard()
            {
                Title = "Bird",
                Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
            },

                new NbaCard()
                {
                    Title = "Jordan",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Lebron",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Rodman",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Shaq",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                }
                };
            return Json(cards);
                
        }

        // GET: api/Nba/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Nba
        public void Post([FromBody]NbaCard card)
        {
            var receivedCard = card;
        }

        // PUT: api/Nba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Nba/5
        public void Delete(int id)
        {
        }
    }
}

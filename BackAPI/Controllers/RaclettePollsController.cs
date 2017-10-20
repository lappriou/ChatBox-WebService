using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BackAPI.Models;
using ChatBot.PCL;

namespace BackAPI.Controllers
{
    public class RaclettePollsController : ApiController
    {
        private BackAPIContext db = new BackAPIContext();

        // GET: api/RaclettePolls
        public IQueryable<RaclettePoll> GetRaclettePolls()
        {
            return db.RaclettePolls;
        }

        // GET: api/RaclettePolls/5
        [ResponseType(typeof(RaclettePoll))]
        public IHttpActionResult GetRaclettePoll(int id)
        {
            RaclettePoll raclettePoll = db.RaclettePolls.Find(id);
            if (raclettePoll == null)
            {
                return NotFound();
            }

            return Ok(raclettePoll);
        }

        // PUT: api/RaclettePolls/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRaclettePoll(int id, RaclettePoll raclettePoll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != raclettePoll.ID)
            {
                return BadRequest();
            }

            db.Entry(raclettePoll).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaclettePollExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RaclettePolls
        [ResponseType(typeof(RaclettePoll))]
        public IHttpActionResult PostRaclettePoll(RaclettePoll raclettePoll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RaclettePolls.Add(raclettePoll);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = raclettePoll.ID }, raclettePoll);
        }

        // DELETE: api/RaclettePolls/5
        [ResponseType(typeof(RaclettePoll))]
        public IHttpActionResult DeleteRaclettePoll(int id)
        {
            RaclettePoll raclettePoll = db.RaclettePolls.Find(id);
            if (raclettePoll == null)
            {
                return NotFound();
            }

            db.RaclettePolls.Remove(raclettePoll);
            db.SaveChanges();

            return Ok(raclettePoll);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RaclettePollExists(int id)
        {
            return db.RaclettePolls.Count(e => e.ID == id) > 0;
        }
    }
}
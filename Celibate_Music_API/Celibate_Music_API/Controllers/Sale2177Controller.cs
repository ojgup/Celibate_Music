using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Celibate_Music_API.Models;

namespace Celibate_Music_API.Controllers
{
    public class Sale2177Controller : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/Sale2177
        public IQueryable<Sale2177> GetSale2177()
        {
            return db.Sale2177;
        }

        // GET: api/Sale2177/5
        [ResponseType(typeof(Sale2177))]
        public async Task<IHttpActionResult> GetSale2177(DateTime id)
        {
            Sale2177 sale2177 = await db.Sale2177.FindAsync(id);
            if (sale2177 == null)
            {
                return NotFound();
            }

            return Ok(sale2177);
        }

        // PUT: api/Sale2177/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSale2177(DateTime id, Sale2177 sale2177)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sale2177.SALEDATE)
            {
                return BadRequest();
            }

            db.Entry(sale2177).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sale2177Exists(id))
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

        // POST: api/Sale2177
        [ResponseType(typeof(Sale2177))]
        public async Task<IHttpActionResult> PostSale2177(Sale2177 sale2177)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sale2177.Add(sale2177);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Sale2177Exists(sale2177.SALEDATE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sale2177.SALEDATE }, sale2177);
        }

        // DELETE: api/Sale2177/5
        [ResponseType(typeof(Sale2177))]
        public async Task<IHttpActionResult> DeleteSale2177(DateTime id)
        {
            Sale2177 sale2177 = await db.Sale2177.FindAsync(id);
            if (sale2177 == null)
            {
                return NotFound();
            }

            db.Sale2177.Remove(sale2177);
            await db.SaveChangesAsync();

            return Ok(sale2177);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Sale2177Exists(DateTime id)
        {
            return db.Sale2177.Count(e => e.SALEDATE == id) > 0;
        }
    }
}
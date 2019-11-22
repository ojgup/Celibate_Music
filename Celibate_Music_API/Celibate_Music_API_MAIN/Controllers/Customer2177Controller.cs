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
using Celibate_Music_API_MAIN.Models;

namespace Celibate_Music_API_MAIN.Controllers
{
    public class Customer2177Controller : ApiController
    {
        private DADEntities2 db = new DADEntities2();

        // GET: api/Customer2177
        public IQueryable<Customer2177> GetCustomer2177()
        {
            return db.Customer2177;
        }

        // GET: api/Customer2177/5
        [ResponseType(typeof(Customer2177))]
        public async Task<IHttpActionResult> GetCustomer2177(int id)
        {
            Customer2177 customer2177 = await db.Customer2177.FindAsync(id);
            if (customer2177 == null)
            {
                return NotFound();
            }

            return Ok(customer2177);
        }

        // PUT: api/Customer2177/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCustomer2177(int id, Customer2177 customer2177)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer2177.CUSTOMERID)
            {
                return BadRequest();
            }

            db.Entry(customer2177).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer2177Exists(id))
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

        // POST: api/Customer2177
        [ResponseType(typeof(Customer2177))]
        public async Task<IHttpActionResult> PostCustomer2177(Customer2177 customer2177)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customer2177.Add(customer2177);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Customer2177Exists(customer2177.CUSTOMERID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = customer2177.CUSTOMERID }, customer2177);
        }

        // DELETE: api/Customer2177/5
        [ResponseType(typeof(Customer2177))]
        public async Task<IHttpActionResult> DeleteCustomer2177(int id)
        {
            Customer2177 customer2177 = await db.Customer2177.FindAsync(id);
            if (customer2177 == null)
            {
                return NotFound();
            }

            db.Customer2177.Remove(customer2177);
            await db.SaveChangesAsync();

            return Ok(customer2177);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Customer2177Exists(int id)
        {
            return db.Customer2177.Count(e => e.CUSTOMERID == id) > 0;
        }
    }
}
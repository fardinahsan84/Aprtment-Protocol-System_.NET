using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApartmentProtocolServiceSystemAPI.Repository;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Controllers
{
        [RoutePrefix("api/guests")]
        public class GuestController : ApiController
        {
            IRepository<guest> repo = new GuestRepository();
            IGuestRepository guestsrepo;
            public GuestController()
            {
                this.repo = new GuestRepository();
                this.guestsrepo = new GuestRepository();
            }

            [Route("")]
            public IHttpActionResult Get()
            {
                return Ok(repo.GetAll().ToList());
            }
        [Route("{id}",Name ="GetGuestById")]
        public IHttpActionResult Get(int id)
        {
            guest guest = repo.Get(id);

            return Ok(guest);
        }



        [Route("")]
        public IHttpActionResult Post([FromBody]guest guest)
        {
            repo.Insert(guest);
            return Ok(guest);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]guest guest, [FromUri]int id)
        {
            guest.id = id;
            repo.Update(guest);
            return Ok(guest);
        }
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
    }

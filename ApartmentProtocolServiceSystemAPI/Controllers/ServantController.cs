using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApartmentProtocolServiceSystemAPI.Models;
using ApartmentProtocolServiceSystemAPI.Repository;

namespace ApartmentProtocolServiceSystemAPI.Controllers
{
   

    [RoutePrefix("api/servants")]
    public class ServantController : ApiController
    {
        IRepository<servant> repo = new ServantRepository();
        IServantRepository servantrepo;
        public ServantController()
        {
            this.repo = new ServantRepository();
            this.servantrepo = new ServantRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

        [Route("{id}", Name = "GetServantById")]
        public IHttpActionResult Get(int id)
        {
            servant servant = repo.Get(id);
            servant.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/", Method = "GET", Rel = "Get all the Servant list" });
            servant.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/", Method = "POST", Rel = "Create a new Servant resource" });
            servant.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/" + servant.id, Method = "PUT", Rel = "Modify an existing Servant resource" });
            servant.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/" + servant.id, Method = "DELETE", Rel = "Delete an existing servant resource" });
            return Ok(servant);
        }

        [Route("")]
        public IHttpActionResult Post([FromBody]servant servant)
        {
            repo.Insert(servant);
            string url = Url.Link("GetServantById", new { id = servant.id });
            return Created(url, servant);
        }
        [Route("{id}")]
        public IHttpActionResult Put([FromBody]servant servant, [FromUri]int id)
        {
            servant.id = id;
            repo.Update(servant);
            return Ok(servant);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}

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

    [RoutePrefix("api/flatmembers")]
    public class FlatMemberController : ApiController
    {
        IRepository<flat_member> repo = new MembersRepository();
        IMembersRepository memberrepo;
        public FlatMemberController()
        {
            this.repo = new MembersRepository();
            this.memberrepo = new MembersRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

        [Route("{id}", Name = "GetFlatMemberById")]
        public IHttpActionResult Get(int id)
        {
            flat_member member = repo.Get(id);
            member.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/", Method = "GET", Rel = "Get all the flat member list" });
            member.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/", Method = "POST", Rel = "Create a new flat member resource" });
            member.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/" + member.id, Method = "PUT", Rel = "Modify an existing flat member resource" });
            member.Links.Add(new Links() { HRef = "http://localhost:56895/api/flatmembers/" + member.id, Method = "DELETE", Rel = "Delete an existing flat member resource" });
            return Ok(member);
        }

        [Route("")]
        public IHttpActionResult Post([FromBody]flat_member member)
        {
            repo.Insert(member);
            string url = Url.Link("GetFlatMemberById", new { id = member.id });
            return Created(url, member);
        }
        [Route("{id}")]
        public IHttpActionResult Put([FromBody]flat_member member, [FromUri]int id)
        {
            member.id = id;
            repo.Update(member);
            return Ok(member);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}

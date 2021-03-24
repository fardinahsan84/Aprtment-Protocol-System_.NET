using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApartmentProtocolServiceSystemAPI.Models;
using ApartmentProtocolServiceSystemAPI.Repository;
using ApartmentProtocolServiceSystemAPI.Attributes;

namespace ApartmentProtocolServiceSystemAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        IRepository<user> repo = new UsersRepository();
        IUsersRepository usersrepo;
        public UsersController()
        {
            this.repo = new UsersRepository();
            this.usersrepo = new UsersRepository();
        }

        [Route("")] [BasicAuthentication]
        public IHttpActionResult Get()
        {
     
            return Ok(repo.GetAll().ToList());
        }

      


    }
}

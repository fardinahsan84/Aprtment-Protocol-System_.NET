using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApartmentProtocolServiceSystemAPI.Models;
using ApartmentProtocolServiceSystemAPI.Repository;

//Work Done Get,getbyID,post,put,delete

namespace ApartmentProtocolServiceSystemAPI.Controllers
{
    
    [RoutePrefix("api/servicecharge")]
    public class ServiceChargeRecordController : ApiController
    {
        IRepository<service_charge_payment_record> repo = new ServiceChargeRepository();
        IServiceChargeRepository servicechargerepo;
        public ServiceChargeRecordController()
        {
            this.repo = new ServiceChargeRepository();
            this.servicechargerepo = new ServiceChargeRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

        [Route("{id}", Name="GetServiceById")]
        public IHttpActionResult Get(int id)
        {
            service_charge_payment_record service = repo.Get(id);

            return Ok(service);
        }



        [Route("")]
        public IHttpActionResult Post([FromBody]service_charge_payment_record servicecharge)
        {
            repo.Insert(servicecharge);
            return Ok(servicecharge);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]service_charge_payment_record servicecharge, [FromUri]int id)
        {
            servicecharge.id = id;
            repo.Update(servicecharge);
            return Ok(servicecharge);
        }
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }


    }
}

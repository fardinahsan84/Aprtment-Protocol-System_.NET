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
   
    [RoutePrefix("api/noticeboard")]
    public class NoticeBoardController : ApiController
    {
        IRepository<notice_board> repo = new NoticeRepository();
        INoticeRepository noticerepo;
        public NoticeBoardController()
        {
            this.repo = new NoticeRepository();
            this.noticerepo = new NoticeRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

        [Route("{id}", Name ="GetNoticeById")]
        public IHttpActionResult Get(int id)
        {
            notice_board notice = repo.Get(id);
          
            return Ok(notice);
        }



        [Route("")]
        public IHttpActionResult Post([FromBody]notice_board notice_board)
        {
            repo.Insert(notice_board);
            return Ok(notice_board);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]notice_board notice_board, [FromUri]int id)
        {
            notice_board.id = id;
            repo.Update(notice_board);
            return Ok(notice_board);
        }
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}

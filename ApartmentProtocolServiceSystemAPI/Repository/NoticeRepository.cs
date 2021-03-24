using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
  
    public class NoticeRepository : Repository<notice_board>, INoticeRepository
    {
        public IEnumerable<notice_board> GetHighestnotice()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<notice_board> NoticeListFilter()
        {
            throw new NotImplementedException();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
  
    public class GuestRepository : Repository<guest>, IGuestRepository
    {

        public IEnumerable<guest> GuestListFilter()
        {
            throw new NotImplementedException();
        }
    }
}
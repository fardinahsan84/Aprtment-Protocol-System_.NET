using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
   
    public class ServantRepository : Repository<servant>, IServantRepository
    {
        public IEnumerable<servant> ServantListFilter()
        {
            throw new NotImplementedException();
        }
    }
}
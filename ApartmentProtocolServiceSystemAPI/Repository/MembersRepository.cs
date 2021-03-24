using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
    
    public class MembersRepository : Repository<flat_member>, IMembersRepository
    {

        public IEnumerable<flat_member> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
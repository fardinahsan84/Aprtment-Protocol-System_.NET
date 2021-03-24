using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
   
    public class UsersRepository : Repository<user>, IUsersRepository
    {

        public IEnumerable<user> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
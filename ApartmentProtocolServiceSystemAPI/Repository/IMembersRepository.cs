using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
    
    public interface IMembersRepository : IRepository<flat_member>
    {
        IEnumerable<flat_member> GetHighestPaidEmployees();
    }
}


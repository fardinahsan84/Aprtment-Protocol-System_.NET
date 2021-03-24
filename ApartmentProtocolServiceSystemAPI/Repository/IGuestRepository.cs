using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
   
    public interface IGuestRepository : IRepository<guest>
    {
        IEnumerable<guest> GuestListFilter();
    }
}

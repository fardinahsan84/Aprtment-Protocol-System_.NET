using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
    public interface IServantRepository : IRepository<servant>
    {
        IEnumerable<servant> ServantListFilter();
    }
}

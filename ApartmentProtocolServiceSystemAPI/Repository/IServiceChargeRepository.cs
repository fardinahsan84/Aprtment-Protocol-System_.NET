using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
  
    public interface IServiceChargeRepository : IRepository<service_charge_payment_record>
    {
        IEnumerable<service_charge_payment_record> GetHighestPaidService();
    }
}

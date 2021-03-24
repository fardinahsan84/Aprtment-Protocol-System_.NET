using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApartmentProtocolServiceSystemAPI.Models;

namespace ApartmentProtocolServiceSystemAPI.Repository
{
    
    public class ServiceChargeRepository : Repository<service_charge_payment_record>, IServiceChargeRepository
    {
        public IEnumerable<service_charge_payment_record> GetHighestPaidService()
        {
            throw new NotImplementedException();
        }


    }
}
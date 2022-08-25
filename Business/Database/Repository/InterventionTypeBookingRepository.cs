using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class InterventionTypeBookingRepository : RepositoryBase<InterventionTypeBooking>
    {
        public InterventionTypeBookingRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

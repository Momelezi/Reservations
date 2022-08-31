using Business.Database.Contracts;
using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class VenueRoomRepository : RepositoryBase<VenueRoom>, IVenueRoomRepository
    {
        public VenueRoomRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

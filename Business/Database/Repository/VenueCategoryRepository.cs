using Business.Database.Contracts;
using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class VenueCategoryRepository : RepositoryBase<VenueCategory>, IVenueCategoryRepository
    {
        public VenueCategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

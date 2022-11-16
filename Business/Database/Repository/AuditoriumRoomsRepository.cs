using Business.Database.Contracts;
using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class AuditoriumRoomsRepository: RepositoryBase<AuditoriumRoom>,IAuditoriumRoomsRepository
    {
        public AuditoriumRoomsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class BranchRepository: RepositoryBase<Branch>
    {
        public BranchRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

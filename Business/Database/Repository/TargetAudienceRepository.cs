﻿using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class TargetAudienceRepository : RepositoryBase<TargetAudience>
    {
        public TargetAudienceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

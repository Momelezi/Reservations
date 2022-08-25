﻿using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    public class InterventionTypeRepository : RepositoryBase<InterventionType>
    {
        public InterventionTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{
    
    public class ComponentsRepository : RepositoryBase<Component>
    {
        public ComponentsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

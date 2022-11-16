using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Domain
{
    public class AuditoriumRoom : BaseEntity
    {
        public int VenueCategoryId { get; set; }
        public virtual VenueCategory VenueCategory { get; set; }
        public string Name { get; set; }
    }
}

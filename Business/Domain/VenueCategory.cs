using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class VenueCategory: BaseEntity
    {
        private ICollection<Venue> _venues;
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> Venues
        {
            get => _venues ?? (_venues = new List<Venue>());
            set => _venues = value;
        }
    }
}

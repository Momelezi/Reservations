using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class VenueRoom
    {
        private ICollection<Venue> _venues;
        public int VenueRoomId { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> _Venues
        {
            get => _venues ?? (_Venues = new List<Venue>());
            set => _venues = value;
        }
    }
}

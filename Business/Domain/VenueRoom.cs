using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class VenueRoom
    {
        public int VenueRoomId { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> _Venues
        {
            get => _Venues ?? (_Venues = new List<Venue>());
            set => _Venues = value;
        }
    }
}

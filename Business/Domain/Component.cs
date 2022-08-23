using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Component
    {
        public int ComponentId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking> _Bookings
        {
            get => _Bookings ?? (_Bookings = new List<Booking>());
            set => _Bookings = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Designation
    {
        private ICollection<Booking> _bookings;
        public int DesignationId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking>Bookings
        {
            get => _bookings ?? (_bookings = new List<Booking>());
            set => _bookings = value;
        }
    }
}

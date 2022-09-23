using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Designation: BaseEntity
    {
        private ICollection<Booking> _bookings;
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking>Bookings
        {
            get => _bookings ?? (_bookings = new List<Booking>());
            set => _bookings = value;
        }
    }
}

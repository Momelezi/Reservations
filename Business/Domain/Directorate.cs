using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Directorate: BaseEntity
    {
        private ICollection<Booking> _bookings;
        private ICollection<Person> _People;
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking> Bookings
        {
            get => _bookings ?? (_bookings = new List<Booking>());
            set => _bookings = value;
        }
        public virtual ICollection<Person> People
        {
            get => _People ?? (_People = new List<Person>());
            set => _People = value;
        }
    }
}

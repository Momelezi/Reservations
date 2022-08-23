using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Directorate
    {
        public int DirectorateId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public virtual ICollection<Booking> _Bookings
        {
            get => _Bookings ?? (_Bookings = new List<Booking>());
            set => _Bookings = value;
        }
        public virtual ICollection<Person> _People
        {
            get => _People ?? (_People = new List<Person>());
            set => _People = value;
        }
    }
}

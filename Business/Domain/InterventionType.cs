using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class InterventionType: BaseEntity
    {
        private ICollection<InterventionTypeBooking> _interventionTypeBookings;
        //public int InterventionTypeId { get; set; }
        public string Descr { get; set; }
        public bool Activity { get; set; }
        public virtual ICollection<InterventionTypeBooking> InterventionTypeBookings
        {
            get => _interventionTypeBookings ?? (_interventionTypeBookings = new List<InterventionTypeBooking>());
            set => _interventionTypeBookings = value;
        }
    }
}

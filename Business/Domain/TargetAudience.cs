using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class TargetAudience: BaseEntity
    {
        private ICollection<TargetAudienceBooking> _targetAudienceBookings;
        //public int TargetAudienceId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TargetAudienceBooking> TargetAudienceBookings
        {
            get => _targetAudienceBookings ?? (_targetAudienceBookings = new List<TargetAudienceBooking>());
            set => _targetAudienceBookings = value;
        }
    }
}

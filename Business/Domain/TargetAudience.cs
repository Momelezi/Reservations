using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class TargetAudience
    {
        public int TargetAudienceId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TargetAudienceBooking> _TargetAudienceBookings
        {
            get => _TargetAudienceBookings ?? (_TargetAudienceBookings = new List<TargetAudienceBooking>());
            set => _TargetAudienceBookings = value;
        }
    }
}

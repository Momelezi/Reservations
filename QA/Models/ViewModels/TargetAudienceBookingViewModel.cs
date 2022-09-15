using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class TargetAudienceBookingViewModel
    {
        public int Id { get; set; }
        public int TargetAudienceId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual TargetAudience TargetAudience { get; set; }
    }
}

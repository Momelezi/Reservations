using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class TargetAudienceBookingViewModel
    {
        public int Id { get; set; }
        public int TargetAudienceId { get; set; }
        public int BookingId { get; set; }

        public virtual BookingViewModel Booking { get; set; }
        public virtual TargetAudienceViewModel TargetAudience { get; set; }
    }
}

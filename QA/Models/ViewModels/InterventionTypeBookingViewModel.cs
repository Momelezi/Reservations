using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class InterventionTypeBookingViewModel
    {
        public int Id { get; set; }
        public int InterventionTypeId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual InterventionType InterventionType { get; set; }
    }
}

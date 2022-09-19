using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class VenueBookingViewModel
    {
        public int VenueBookingId { get; set; }
        public int VenueId { get; set; }
        public int BookingId { get; set; }

        public virtual BookingViewModel Booking { get; set; }
        public virtual VenueViewModel Venue { get; set; }
    }
}

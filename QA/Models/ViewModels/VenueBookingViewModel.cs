using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class VenueBookingViewModel
    {
        public int VenueBookingId { get; set; }
        public int VenueId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Venue Venue { get; set; }
    }
}

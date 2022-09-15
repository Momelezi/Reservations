namespace QA.Models.ViewModels
{
    public class VenueViewModel
    {
        private ICollection<VenueBooking> _venueBookings;
        //public int VenueId { get; set; }
        public int VenueCategoryId { get; set; }
        public int VenueRoomId { get; set; }
        public int Capacity { get; set; }

        public virtual VenueCategory VenueCategory { get; set; }
        public virtual VenueRoom VenueRoom { get; set; }
        public virtual ICollection<VenueBooking> VenueBookings
        {
            get => _venueBookings ?? (_venueBookings = new List<VenueBooking>());
            set => _venueBookings = value;
        }
    }
}

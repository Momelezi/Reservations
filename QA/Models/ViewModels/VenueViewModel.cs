using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class VenueViewModel
    {
        public VenueViewModel()
        {
            VenueBookings = VenueBookings ?? new List<VenueBookingViewModel>();
        }
        public int Id { get; set; }
        public int VenueCategoryId { get; set; }
        public int VenueRoomId { get; set; }
        public int Capacity { get; set; }

        public virtual VenueCategoryViewModel VenueCategory { get; set; }
        public virtual VenueRoomViewModel VenueRoom { get; set; }
        public List <VenueBookingViewModel> VenueBookings {get ;set;}
    }
}

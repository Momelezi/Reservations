using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class VenueRoomViewModel
    {
        public VenueRoomViewModel()
        {
            Venues = Venues ?? new List<VenueViewModel>();
        }
        private ICollection<Venue> _venues;
        public int Id { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VenueViewModel> Venues{ get; set; }
    }
}

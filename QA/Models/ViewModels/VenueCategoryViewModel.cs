using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class VenueCategoryViewModel
    {
        public VenueCategoryViewModel()
        {
            Venues = Venues ?? new List<VenueViewModel>();
        }
        private ICollection<Venue> _venues;
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public List <VenueViewModel> Venues{get ;set ;}
    }
}

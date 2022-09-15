namespace QA.Models.ViewModels
{
    public class VenueRoomViewModel
    {
        private ICollection<Venue> _venues;
        //public int VenueRoomId { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> _Venues
        {
            get => _venues ?? (_Venues = new List<Venue>());
            set => _venues = value;
        }
    }
}

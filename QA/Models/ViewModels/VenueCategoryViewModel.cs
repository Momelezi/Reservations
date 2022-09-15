namespace QA.Models.ViewModels
{
    public class VenueCategoryViewModel
    {
        private ICollection<Venue> _venues;
        //public int VenueCategoryId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> Venues
        {
            get => _venues ?? (_venues = new List<Venue>());
            set => _venues = value;
        }
    }
}

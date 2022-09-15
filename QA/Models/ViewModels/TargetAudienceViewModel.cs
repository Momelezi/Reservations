namespace QA.Models.ViewModels
{
    public class TargetAudienceViewModel
    {
        private ICollection<TargetAudienceBooking> _targetAudienceBookings;
        //public int TargetAudienceId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TargetAudienceBooking> TargetAudienceBookings
        {
            get => _targetAudienceBookings ?? (_targetAudienceBookings = new List<TargetAudienceBooking>());
            set => _targetAudienceBookings = value;
        }
    }
}

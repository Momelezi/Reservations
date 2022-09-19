using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class TargetAudienceViewModel
    {
        public TargetAudienceViewModel()
        {
            TargetAudienceBookings = TargetAudienceBookings ?? new List<TargetAudienceBookingViewModel>();
        }
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TargetAudienceBookingViewModel> TargetAudienceBookings {get ;set ;}
    }
}

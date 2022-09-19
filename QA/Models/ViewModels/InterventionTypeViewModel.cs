using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class InterventionTypeViewModel
    {
        public InterventionTypeViewModel()
        {
            InterventionTypeBookings = InterventionTypeBookings ?? new List<InterventionTypeBookingViewModel>();
        }
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Activity { get; set; }
        public virtual ICollection<InterventionTypeBookingViewModel> InterventionTypeBookings {get ;set ;}
    }
}

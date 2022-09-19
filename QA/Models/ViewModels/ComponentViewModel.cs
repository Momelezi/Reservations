using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class ComponentViewModel
    {
        public ComponentViewModel()
        {
            Bookings = Bookings ?? new List<BookingViewModel>();
        }
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BookingViewModel> Bookings {get;set;}
    }
}

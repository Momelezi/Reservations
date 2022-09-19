using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class BranchViewModel
    {
        public BranchViewModel()
        {
            Bookings = Bookings ?? new List<BookingViewModel>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public List <BookingViewModel> Bookings {get; set; }
    }
}

using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class DesignationViewModel
    {
        public DesignationViewModel()
        {
            Bookings = Bookings ?? new List<BookingViewModel>();
        }
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public List <BookingViewModel> Bookings{ get; set; }
    }
}

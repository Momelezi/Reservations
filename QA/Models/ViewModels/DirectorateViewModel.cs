using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class DirectorateViewModel
    {
        public DirectorateViewModel()
        {
            Bookings = Bookings ?? new List<BookingViewModel>();
            People = People ?? new List<PersonViewModel>();

        }
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public string Name { get; internal set; }
        public List <BookingViewModel> Bookings {get ;set ;}
        public List<PersonViewModel> People {get;set ;}
    }
}

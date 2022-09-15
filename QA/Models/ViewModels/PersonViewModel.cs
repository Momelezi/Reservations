using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Bookings = Bookings ?? new List<BookingViewModel>();
            Directorates = Directorates ?? new List<DirectorateViewModel>();
        }
        private ICollection<Directorate> _directorates;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public int DirectorateId { get; set; }
        public List <BookingViewModel> Bookings{ get; set; }

        public List <DirectorateViewModel> Directorates {get;set;}
    }
}

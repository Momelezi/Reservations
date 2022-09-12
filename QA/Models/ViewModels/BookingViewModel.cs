using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{

    public class BookingViewModel
    {
        public BookingViewModel()
        {
            EquipmentBookings = EquipmentBookings?? new List <EquipmentBookingViewModel>();
        }
        private ICollection<EquipmentBooking> _equipmentBookings;
        private ICollection<InterventionTypeBooking> _interventionTypeBookings;
        private ICollection<TargetAudienceBooking> _targetAudienceBookings;
        private ICollection<VenueBooking> _venueBookings;
        public int Id { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationEnd { get; set; }
        public DateTime? PreparationDate { get; set; }
        public int Requestor { get; set; }
        public int ResponsiblePerson { get; set; }
        public int? ResponsibleDirector { get; set; }
        public int? UnitManager { get; set; }
        public int? BranchId { get; set; }
        public int? DirectorateId { get; set; }
        public int? ComponentId { get; set; }
        public string? Comment { get; set; }
        public int? DesignationId { get; set; }

        public Branch Branch { get; set; }
        public  List <EquipmentBookingViewModel> EquipmentBookings {get; set;}
        public virtual ICollection<InterventionTypeBooking> InterventionTypeBookings
        {
            get => _interventionTypeBookings ?? (_interventionTypeBookings = new List<InterventionTypeBooking>());
            set => _interventionTypeBookings = value;
        }
        public virtual ICollection<TargetAudienceBooking> TargetAudienceBookings {
           get => _targetAudienceBookings ?? (_targetAudienceBookings = new List<TargetAudienceBooking>());
           set => _targetAudienceBookings = value;
        }
        public virtual ICollection<VenueBooking> VenueBookings
        {
            get => _venueBookings ?? (_venueBookings = new List<VenueBooking>());
            set => _venueBookings = value;
        }

    }
}

using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Booking: BaseEntity
    {
        private ICollection<EquipmentBooking>  _equipmentBookings;
        private ICollection<InterventionTypeBooking> _interventionTypeBookings;
      //  private ICollection<TargetAudienceBooking> _targetAudienceBookings;
        private ICollection<VenueBooking> _venueBookings;
        //public int BookingId { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationEnd { get; set; }
        public DateTime? PreparationDate { get; set; }
        public int Requestor { get; set; }
        public int ResponsiblePerson { get; set; }
        public int? ResponsibleDirector { get; set; }
        public  int? UnitManager { get; set; }
        public int? BranchId { get; set; }
        public int? DirectorateId { get; set; }
        public int? ComponentId { get; set; }
        public string Comment { get; set; }
        public int? DesignationId { get; set; }

        public  Branch Branch { get; set; }
        public virtual ICollection<EquipmentBooking> EquipmentBookings {
            get => _equipmentBookings ?? (_equipmentBookings = new List<EquipmentBooking>());
            set => _equipmentBookings = value;
        }
        public virtual ICollection<InterventionTypeBooking> InterventionTypeBookings {
            get => _interventionTypeBookings ?? (_interventionTypeBookings = new List<InterventionTypeBooking>());
            set => _interventionTypeBookings = value;
        }
        //public virtual ICollection<TargetAudienceBooking> TargetAudienceBookings {
        //    get => _targetAudienceBookings ?? (_targetAudienceBookings = new List<TargetAudienceBooking>());
        //    set => _targetAudienceBookings = value;
        //}
        public virtual ICollection<VenueBooking> VenueBookings {
            get => _venueBookings ?? (_venueBookings = new List<VenueBooking>());
            set => _venueBookings = value;
        }



    }
}

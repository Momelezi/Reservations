namespace QA.Models.ViewModels
{
    public class EquipmentBookingViewModel
    {
        public int EquipmentId { get; set; }
        public int BookingId { get; set; }

        public BookingViewModel Booking { get; set; }
        public EquipmentViewModel Equipment { get; set; }
    }
}

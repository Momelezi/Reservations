namespace QA.Models.ViewModels
{
    public class EquipmentViewModel
    {
        private ICollection<EquipmentBooking> _equipmentBookings;
        //public int EquipmentId { get; set; }
        public string Descr { get; set; }
        public int EquipmentCategoryId { get; set; }
        public virtual ICollection<EquipmentBooking> EquipmentBookings
        {
            get => _equipmentBookings ?? (_equipmentBookings = new List<EquipmentBooking>());
            set => _equipmentBookings = value;
        }
    }
}

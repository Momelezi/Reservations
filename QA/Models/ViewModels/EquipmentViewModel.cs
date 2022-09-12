using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class EquipmentViewModel
    {
        public EquipmentViewModel()
        {
            EquipmentBookings = EquipmentBookings ?? new List<EquipmentBookingViewModel>();
        }
        public string Descr { get; set; }
        public int EquipmentCategoryId { get; set; }
        public  ICollection<EquipmentBookingViewModel> EquipmentBookings { get; set;}
    }
}

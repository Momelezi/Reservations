using BusinessDomain.Domain;

namespace QA.Models.ViewModels
{
    public class EquipmentCategoryViewModel
    {
        public EquipmentCategoryViewModel()
        {
            Equipments = Equipments ?? new List<EquipmentViewModel>();
        }
        private ICollection<Equipment> _equipments;
        public int Id { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<EquipmentViewModel> Equipments {get ;set ;}
    }
}

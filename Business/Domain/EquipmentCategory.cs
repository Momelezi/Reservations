using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class EquipmentCategory
    {
        public int EquipmentCategoryId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Equipment> _Equipments
        {
            get => _Equipments ?? (_Equipments = new List<Equipment>());
            set => _Equipments = value;
        }
    }
}

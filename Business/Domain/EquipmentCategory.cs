using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class EquipmentCategory
    {
        private ICollection<Equipment> _equipments;
        public int EquipmentCategoryId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Equipment> Equipments
        {
            get => _equipments ?? (_equipments = new List<Equipment>());
            set => _equipments = value;
        }
    }
}

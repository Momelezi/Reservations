using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Equipment
    {
        private ICollection<EquipmentBooking> _equipmentBookings;
        public int EquipmentId { get; set; }
        public string Descr { get; set; }
        public int EquipmentCategoryId { get; set; }
        public virtual ICollection<EquipmentBooking> EquipmentBookings {
            get => _equipmentBookings ?? (_equipmentBookings = new List<EquipmentBooking>());
            set => _equipmentBookings = value;
        }
    }
}

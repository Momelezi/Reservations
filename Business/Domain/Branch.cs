using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Branch
    {
        private ICollection<Booking>_bookings;
        public int BranchId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking> Bookings
        {
            get => _bookings ?? (_bookings = new List<Booking>());
            set => _bookings = value;
        }

    }
}

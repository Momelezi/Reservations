using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Person: BaseEntity
    {
        private ICollection<Directorate> _directorates;
        //public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public int DirectorateId { get; set; }
        public virtual ICollection<Booking> _Bookings
        {
            get => _Bookings ?? (_Bookings = new List<Booking>());
            set => _Bookings = value;
        }

        public virtual ICollection<Directorate> Directorates
        {
            get => _directorates ?? (_directorates = new List<Directorate>());
            set => _directorates = value;
        }
    }
}

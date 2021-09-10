using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager
{
    class Appointment
    {
        public int AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WelchDentistry.Models
{

    public class Appointment
    {
        public int ID { get; set; }
        [Display(Name = "Paitent Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Date/Time")]
        [DataType(DataType.Date)]
        public DateTime AppointmentTime { get; set; }
        [Display(Name = "Paitent Doctor")]
        public string CustomerDoctor { get; set; }
        public string UserName { get; set; }
    }
}

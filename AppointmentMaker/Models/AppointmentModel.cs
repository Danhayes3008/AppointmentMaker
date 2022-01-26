using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20), MinLength(4)]
        [DisplayName("Patient's Full name")]
        public string PatientName { get; set; }
        [DisplayName("Address Line 1")]
        public string AddressLine1 { get; set; }
        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }
        [DisplayName("County")]
        public string County { get; set; }
        [DisplayName("Town")]
        public string Town { get; set; }
        [DisplayName("PostCode")]
        public string PostCode { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Currency)]
        [Range(90000, int.MaxValue, ErrorMessage = "We do not treat people with less then £90,000.00 net worth. Try the NHS")]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientWorth { get; set; }
        [DisplayName ("Doctor's name")]
        public string DoctorName { get; set; }
        [DisplayName("Pain Level (1 low to 10 high)")]
        [Range(1,10)]
        public int PainLevel { get; set; }
    }
}

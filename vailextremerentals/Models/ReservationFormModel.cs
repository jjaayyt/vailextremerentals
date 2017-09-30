using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCEmail.Models
{
    public class ReservationFormModel
    {
        [Required, Display(Name = "CUSTOMER NAME")]
        public string FromName { get; set; }

        [Required, Display(Name = "E-MAIL"), EmailAddress]
        public string FromEmail { get; set; }

        [Required, Display(Name = "PHONE"), Phone]
        public string FromTelephoneNumber { get; set; }

        [Required, Display(Name = "RESERVE THIS MODEL")]
        public string SelectedRental { get; set; }

        [Required, Display(Name = "EXPECTED START/DELIVERY DATE")]
        public string StartDate { get; set; }

        [Required, Display(Name = "EXPECTED RETURN DATE")]
        public string EndDate { get; set; }

        public string SpecialRequest { get; set; }
    }


}

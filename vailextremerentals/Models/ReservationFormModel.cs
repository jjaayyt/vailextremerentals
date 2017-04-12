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

        [Required, Display(Name = "RENTAL AGREEMENT & RELEASE OF LIABILITY")]
        public bool Release { get; set; }

        [Required, Display(Name = "CREDIT CARD NUMBER")]
        public string CreditCardNumber { get; set; }

        [Required, Display(Name = "CREDIT CARD TYPE")]
        public string CCType { get; set; }

        [Required, Display(Name = "CVV2 NUMBER")]
        public string CVV2Number { get; set; }

        [Required, Display(Name = "NAME ON CARD")]
        public string NameOnCreditCard { get; set; }

        [Required, Display(Name = "EXPIRATION MONTH")]
        public string ExpirationMonth { get; set; }

        [Required, Display(Name = "EXPIRATION YEAR")]
        public string ExpirationYear { get; set; }
    }


}

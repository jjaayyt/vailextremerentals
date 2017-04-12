using System.ComponentModel.DataAnnotations;

namespace MVCEmail.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name="CUSTOMER NAME")]
        public string FromName { get; set; }

        [Required, Display(Name = "TELEPHONE"), Phone]
        public string FromTelephoneNumber { get; set; }

        [Required, Display(Name = "E-MAIL"), EmailAddress]
        public string FromEmail { get; set; }

        [Required, Display(Name = "MESSAGE")]
        public string Message { get; set; }
    }
}
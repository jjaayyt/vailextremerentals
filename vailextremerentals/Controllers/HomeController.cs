﻿using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Web.Routing;

namespace vailextremerentals.Controllers
{
    //[Route("")]
    //[RequireHttps]
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("home/index")]
        [Route("rentals")]
        [Route("")]
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

        [RequireHttps]
        [Route("contact")]
        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [RequireHttps]
        [Route("legal")]
        public ActionResult Legal()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [RequireHttps]
        [Route("reservations")]
        public ActionResult Reservation()
        {
            ViewData["Message"] = "Your reservation page.";

            return View();
        }

        [RequireHttps]
        [Route("delivery")]
        public ActionResult Delivery()
        {
            ViewData["Message"] = "Your delivery page.";

            return View();
        }

        [RequireHttps]
        [Route("media")]
        public ActionResult Media()
        {
            ViewData["Message"] = "Your delivery page.";

            return View();
        }

        [RequireHttps]
        [Route("contact")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                System.Random rndmnmbr = new System.Random();
                int result = rndmnmbr.Next(11111, 99999);
                var confirmationnumber = result.ToString();
                var message = new MailMessage();
                message.To.Add(new MailAddress("vailextremerentals@gmail.com"));
                message.From = new MailAddress(model.FromEmail.Trim());
                message.Subject = "NEW CUSTOMER QUESTION #".ToUpper() + confirmationnumber + ". " + model.FromName.Trim().ToUpper();
                message.Body = string.Format("<table cellpadding=10 cellspacing=0 border=0><tr width=175><td style=text-align:right;vertical-align:top;font-weight:bold>CUSTOMER</td><td>" + model.FromName.Trim().ToUpper() + "</td></tr><tr><td style=text-align:right;vertical-align:top;font-weight:bold>TELEPHONE</td><td>" + model.FromTelephoneNumber.Trim() + " </td></tr><tr><td style=text-align:right;vertical-align:top;font-weight:bold>EMAIL</td><td>" + model.FromEmail.Trim().ToLower() + " </td></tr><tr><td style=text-align:right;vertical-align:top;font-weight:bold>MESSAGE</td><td>" + model.Message + "</td></tr></table>");
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "vailextremerentals@gmail.com",
                        Password = "Ui816577"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent_Contact");
                }
            }
            return View(model);
        }

        [RequireHttps]
        [Route("reservations")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Reservation(ReservationFormModel model)
        {
            if (ModelState.IsValid)
            {
                var FromName = model.FromName.ToUpper().Trim();
                var FromEmail = model.FromEmail.ToLower().Trim();
                var FromTelephoneNumber = model.FromTelephoneNumber.ToUpper().Trim();

                var RentalSelected = model.SelectedRental.ToUpper().Trim();
                var StartDate = model.StartDate.ToUpper().Trim();
                var EndDate = model.EndDate.ToUpper().Trim();

                var SpecialRequest = model.SpecialRequest.ToUpper().Trim();

                //var CreditCardType = model.CCType.ToUpper().Trim();

                //var CreditCardNumber = model.CreditCardNumber.ToUpper().Trim();
                //var CVV2Number = model.CVV2Number.ToUpper().Trim();

                //var NameOnCreditCard = model.NameOnCreditCard.ToUpper().Trim();

                //var ExpirationMonth = model.ExpirationMonth.ToUpper().Trim();
                //var ExpirationYear = model.ExpirationYear.ToUpper().Trim();

                System.Random rndmnmbr = new System.Random();
                int result = rndmnmbr.Next(11111, 99999);
                var confirmationnumber = result.ToString();
                var message = new MailMessage();
                message.To.Add(new MailAddress("vailextremerentals@gmail.com"));
                message.From = new MailAddress(model.FromEmail.Trim());
                message.Subject = "NEW RESERVATION REQUEST #".ToUpper() + confirmationnumber + ". " + model.FromName.Trim().ToUpper();
                message.Body = string.Format("<table cellpadding=10 cellspacing=0 border=0> <tr width=175> <td style=text-align:right;vertical-align:top;font-weight:bold>CUSTOMER</td><td>" + FromName + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>E-MAIL</td><td>" + FromEmail + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>TELEPHONE</td><td>" + FromTelephoneNumber + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>RESERVED MODEL</td><td>" + RentalSelected + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>EXPECTED START DATE</td><td>" + StartDate + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>EXPECTED END DATE</td><td>" + EndDate + "</td></tr><tr> <td style=text-align:right;vertical-align:top;font-weight:bold>SPECIAL REQUEST(S)</td><td>" + SpecialRequest + "</td></tr></table>");
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "vailextremerentals@gmail.com",
                        Password = "Ui816577"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent_Reservation");
                }
            }
            return View(model);
        }

        [RequireHttps]
        [Route("message_received")]
        public ActionResult Sent_Contact()
        {
            return View();
        }

        [RequireHttps]
        [Route("reservation_received")]
        public ActionResult Sent_Reservation()
        {
            return View();
        }
    }
}

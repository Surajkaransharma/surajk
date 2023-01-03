using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MileStone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MainlandSetupinDubai()
        {           

            return View();
        }

        public ActionResult Freezone()
        {

            return View();
        }
        public ActionResult BusinessLicense()
        {

            return View();
        }


        public ActionResult ProService()
        {

            return View();
        }

        public ActionResult BankAssistance()
        {

            return View();
        }
        public ActionResult BusinessSponsor()
        {

            return View();
        }

        public class Contactmodel
        {
            public String Name { get; set; }
            public String Email { get; set; }
            public String msg { get; set; }
            public String Mobile { get; set; }
        }

        public JsonResult ContactEmail(Contactmodel Cmodel)
        {

            try
            {
                String Uname = Cmodel.Name;
                String UEmail = Cmodel.Email;
                String UMsg = Cmodel.msg;
                String MobileNo = Cmodel.Mobile;
                MailMessage newmail = new MailMessage();
                MailAddress toadd = new MailAddress("info@milestonebusinessdubai.com");
                MailAddress fromadd = new MailAddress("info@milestonebusinessdubai.com");

                newmail.Subject = "Contact Email";
                string msg = "<html><head><meta content = 'text/html; charset=utf-8' http - equiv = 'Content-Type'/><meta name = 'description' content = 'Appointment Reminder Email Template'></head>" +
                    "<style>a:hover {text - decoration: underline !important;}</style><body marginheight = '0' topmargin = '0' marginwidth = '0' style = 'margin: 0px; background-color: #f2f3f8;' leftmargin = '0'>" +
                    "<table cellspacing = '0' border = '0' cellpadding = '0' width = '100%' bgcolor = '#f2f3f8' style = '@import url(https://fonts.googleapis.com/css?family=Rubik:300,400,500,700|Open+Sans:300,400,600,700); font-family: 'Open Sans', sans-serif;'>" +
                    "<tr><td><table style = 'background-color: #f2f3f8; max-width:670px; margin:0 auto;' width = '100%' border = '0' align = 'center' cellpadding = '0' cellspacing = '0'><tr>" +
                    "<td style = 'height:80px;'> &nbsp;</td></tr><tr><td style = 'height:20px;'> &nbsp;</td></tr><tr><td>" +
                    "<table width = '95%' border = '0' align = 'center' cellpadding = '0' cellspacing = '0' style = 'max-width:670px; background:#fff; border-radius:3px;-webkit-box-shadow:0 6px 18px 0 rgba(0,0,0,.06);-moz-box-shadow:0 6px 18px 0 rgba(0,0,0,.06);box-shadow:0 6px 18px 0 rgba(0,0,0,.06);padding:0 40px;'>" +
                    "<tr><td style = 'height:40px;'> &nbsp;</td></tr><tr><td style = 'text-align:center;'><a href = 'http://milestonebusinessdubai.com/' title = 'logo' target = '_blank'>" +
                    "<img width = '25%' src = 'http://milestonebusinessdubai.com/Images/milestone3.png' title = 'logo' alt = 'logo'></a></td></tr><tr><td style = 'padding:0 15px; text-align:center;'>" +
                    "<h1 style = 'color:#1e1e2d; font-weight:400; margin:0;font-size:32px;font-family:'Rubik',sans-serif;'> Contact Email </h1><span style = 'display:inline-block; vertical-align:middle; margin:29px 0 26px; border-bottom:1px solid #cecece; width: 100px; '></span>" +
                    "</td></tr><tr><td><table cellpadding = '0' cellspacing = '0' style = 'width: 100%; border: 1px solid #ededed'><tbody><tr>" +
                    "<td style = 'padding: 10px; border-bottom: 1px solid #ededed; border-right: 1px solid #ededed; width: 35%; font-weight:600; color:rgba(0,0,0,.64)'>Name </td>" +
                    "<td style = 'padding: 10px; border-bottom: 1px solid #ededed; color: #455056;'>" + Uname + "</td></tr>" +
                    "<tr><td style = 'padding: 10px; border-bottom: 1px solid #ededed; border-right: 1px solid #ededed; width: 35%; font-weight:600; color:rgba(0,0,0,.64)'>Email </td>" +
                    "<td style = 'padding: 10px; border-bottom: 1px solid #ededed; color: #455056;'>" + UEmail + " </td></tr>" +
                    "<tr><td style = 'padding: 10px; border-right: 1px solid #ededed; width: 35%;font-weight:600; color:rgba(0,0,0,.64)'>Message:</td>" +
                    "<td style = 'padding: 10px; color: #455056;'>" + UMsg + ".</td></tr></tbody>" +
                    "</table></td></tr><tr><td style = 'height:40px;'> &nbsp;</td></tr></table></td></tr><tr><td style = 'height:20px;'> &nbsp;</td></tr></table></td></tr></table></body>" +
                    "</html> ";
                newmail.Body = msg;
                newmail.To.Add(toadd);
                newmail.From = fromadd;
                newmail.IsBodyHtml = true;
                SmtpClient sserver = new SmtpClient();
                sserver.Host = "mail.milestonebusinessdubai.com";
                sserver.Credentials = new System.Net.NetworkCredential("info@milestonebusinessdubai.com", "Nainani@UAE22");
                sserver.DeliveryMethod = SmtpDeliveryMethod.Network;
                sserver.Port = 25;
                sserver.Send(newmail);

                var res = new { res = "1" };
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                var res = new { res = "0" };
                return Json(res, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreateForm.Models;

namespace CreateForm.Controllers
{
    public class SendMailController : Controller
    {
        //
        // GET: /SendMail/

        public ActionResult Index()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                string smtpUserName = "smtp@coffeemugvn.com";
                string smtpPassword = "smtp@coffeemugvn.com";
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 465;

                string emailTo = "smtp@coffeemugvn.com"; // Khi có liên hệ sẽ gửi về thư của mình
                string subject = model.Subject;
                string body = string.Format("You receive a mail from <b>{0}</b><br/>Email: {1}<br/>Message: </br>{2}",
                    model.Name, model.EmailAddress, model.Message);

                ConfigSendMailService service = new ConfigSendMailService();

                bool kq = service.Send(smtpUserName, smtpPassword, smtpHost, smtpPort,
                    emailTo, subject, body);

                if (kq)
                    ModelState.AddModelError("", "Thank you for your contact!");
                else
                    ModelState.AddModelError("", "Send to error. Please contact to admin!");
            }
            return View(model);
        }

    }
}

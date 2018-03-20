using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.KeyVault.Models;

namespace portfolio.Pages
{

    public class IndexModel : PageModel
    {
        // BRIDGE TO GREETINGS MODEL
        [BindProperty]
        public Model.MyContact bridgeMyContact { get; set; }

        // DB-RELATED: CONNECT MY DATABASE TO THIS MODEL
        private DbBuilder _myDB;
        public IndexModel(DbBuilder myDB)
        {
            _myDB = myDB;
        }

        public void OnGet(int ID = 0)
        {
            if (ID > 0)
            {
                bridgeMyContact = _myDB.MyContact.Find(ID);
            }
        }

        // EMAIL-RELATED
        public string Message { get; set; }
        public IActionResult OnPost(int id = 0)
        {
            if (id > 0)
            {
                bridgeMyContact = _myDB.MyContact.Find(id);

                try
                {
                    // SEND 
                    MailMessage Mailer = new MailMessage();

                    Mailer.Subject = bridgeMyContact.Subject;
                    Mailer.Body = bridgeMyContact.Message;
                    Mailer.From = new MailAddress(bridgeMyContact.Email, bridgeMyContact.Name);

                    Mailer.IsBodyHtml = true;

                    using (SmtpClient smtpServer = new SmtpClient())
                    {
                        smtpServer.EnableSsl = true;
                        smtpServer.Host = "smtp.ado-design.com"; // CHANGE
                        smtpServer.Port = 143; // CHANGE
                        smtpServer.UseDefaultCredentials = false;
                        smtpServer.Send(Mailer);
                    }

                    // DB-RELATED: ASSIGN SEND INFO TO DATABASE
                    bridgeMyContact.sendDate = DateTime.Now.ToString();
                    bridgeMyContact.sendIP = this.HttpContext.Connection.RemoteIpAddress.ToString();


                    // DB-RELATED: UPDATE RECORD ON THE DATABASE 
                    _myDB.MyContact.Update(bridgeMyContact);
                    _myDB.SaveChanges();


                    return RedirectToPage("Thankyou");
                }
                catch
                {
                    Message = "Oops, your message was not sent.";
                }
            }

            return Page();
        }

    }
}


using Mandrill;
using Mandrill.Models;
using Mandrill.Requests.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailChimpService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected async void Button1_Click(object sender, EventArgs e)
        {




                MandrillApi api = new MandrillApi("Mandrill Api Key", true);

                IEnumerable<EmailAddress> addresses = new[]
            {
                new EmailAddress("Toemailid@xxx.xx", "Name Of the Contact"),
                
            };




                var message = new EmailMessage();

                message.FromEmail = "Frommail@xxx.xxx";
                message.FromName = "Your name";
            message.Html = "emailbody";
                message.Text = "emailbodytext";
            message.Subject = "subject";
                message.To = addresses;
              

                SendMessageRequest req = new SendMessageRequest(message);

                var returnvalue = await api.SendMessage(req);
             
            }


     

      
    }
}
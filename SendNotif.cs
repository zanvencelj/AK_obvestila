using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_obvestila
{
    internal class SendNotif
    {
        //smtp.Port = 587;
        //smtp.Host = "smtp.gmail.com";
        public string sender = Properties.Settings.Default.sender;
        public string password = Properties.Settings.Default.password;
        public string reciever = Properties.Settings.Default.reciever;
        public string server = Properties.Settings.Default.server;
        public int port = Properties.Settings.Default.port;


        public string messageTitle = "Obvestila";
       
        public string getHtml(string message, string title)
        {
            try
            {
                string messageBody = String.Format("<h3> {0} </h3>", title);
                messageBody += message;
                messageBody += "<br><br>Made by Vanted";

                return messageBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public void Email(string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(sender);
                message.To.Add(new MailAddress(reciever));
                message.Subject = messageTitle;
                message.IsBodyHtml = true;
                message.Body = body;
                smtp.Port = port;
                smtp.Host = server;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(sender, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

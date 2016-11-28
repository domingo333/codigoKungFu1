using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Descripción breve de Email
/// </summary>
public class Email
{
    MailMessage m = new MailMessage();
    SmtpClient smtp = new SmtpClient();

    public bool EnviarCorreo (string from, string password,string to,string mesaje){

        try
        {
            m.From = new MailAddress(from);
            m.To.Add(new MailAddress(to));
            m.Body = mesaje;
            //m.IsBodyHtml = true;
            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(from, password);
            smtp.EnableSsl = true;
            smtp.Send(m);

            return true;

        }
        catch(Exception e)
        {
            return false;

        }
        finally
        {

        }

}
}

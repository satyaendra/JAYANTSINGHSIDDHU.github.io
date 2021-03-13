using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using personalDB;

namespace Personal_Blog.Personal_blog
{
    public partial class Home : System.Web.UI.Page
    {
        personalDB.ListView LVAdd = new personalDB.ListView();
        LoginDataLayer objlyr = new LoginDataLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        /// <summary>
        /// contact gamil
        /// </summary>
        void enquiry()
        {

            string name = txtname.Value.Trim();
            string mail = txtemail.Value.Trim();
            string sub = txtsubject.Value.Trim();
            string msg = txtarea.Value.Trim();
            string phn = Txtcontact.Value.Trim();

            StreamReader reader = new StreamReader(Server.MapPath("ConnectGmail.html"));
            string readFile = reader.ReadToEnd();
            string myString = "";
            myString = readFile;
            myString = myString.Replace("$$Name$$", name);
            myString = myString.Replace("$$Email $$", mail);
            //myString = myString.Replace("$$Contact Number $$", txtphone.Value);
            myString = myString.Replace("$$Message $$", msg);
            myString = myString.Replace("$$Subject $$", sub);
            myString = myString.Replace("$$Phone $$", phn);

            MailMessage m = new MailMessage();
            MailAddress sendr = new MailAddress("demouser846@gmail.com");
            MailAddress receiver = new MailAddress(mail);
            SmtpClient client = new SmtpClient();
            ServicePointManager.ServerCertificateValidationCallback =
                                                                  delegate(object s, X509Certificate certificate,
                         X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
                                                                  { return true; };
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("demouser846@gmail.com", "Abc@123456");

            m.Subject = txtsubject.Value.Trim();
            m.From = sendr;
            m.To.Add(receiver);
            m.Priority = MailPriority.High;
            m.Bcc.Add(sendr);
            //m.Body = "Enquiry Details - Name = " + name + "<br/> subject=" + sub + "<br/> message = " +msg;
            m.Body += myString.ToString();
            m.IsBodyHtml = true;
            client.Send(m);

            reader.Dispose();
            Response.Write("<script>alert('Thank you for enquiry');</script>"); 
            
        }
        /// <summary>
        /// clear value contact us
        /// </summary>
        void clear()
        {
           
                txtname.Value = txtemail.Value = Txtcontact.Value = txtsubject.Value = txtarea.Value = "";
            
        }

        void contactus()
        {
            LVAdd.Name = txtname.Value.Trim();
            LVAdd.Email = txtemail.Value.Trim();

            LVAdd.Subjct = txtsubject.Value.Trim();
            LVAdd.Msg = txtarea.Value.Trim();
            LVAdd.Phone = Convert.ToInt64(Txtcontact.Value);

            LoginDataLayer.SRD(LVAdd);
        }
        protected void btnsub_Click(object sender, EventArgs e)
        {
            contactus();
            enquiry();

            clear();
            
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Net.Mail;

namespace SendingEmailwithoutAttachment.Models
{
    public class Email
    {

        private string FromAddress;
        private string strToAddress;
        private string strSmtpClient;
        private string UserID;
        private string Password;
        private string ReplyTo;
        private string SMTPPort;
        private Boolean bEnableSSL;

        private void InitMail()
        {
            FromAddress = System.Configuration.ConfigurationManager.AppSettings.Get("FromAddress");
            strToAddress = System.Configuration.ConfigurationManager.AppSettings.Get("ToAddress");
            //strSmtpClient = System.Configuration.ConfigurationManager.AppSettings.Get("SmtpClient");
            strSmtpClient = "smtp.gmail.com";
            UserID = System.Configuration.ConfigurationManager.AppSettings.Get("UserID");
            Password = System.Configuration.ConfigurationManager.AppSettings.Get("Password");
            ReplyTo = System.Configuration.ConfigurationManager.AppSettings.Get("ReplyTo");
            SMTPPort = System.Configuration.ConfigurationManager.AppSettings.Get("SMTPPort");
            if (System.Configuration.ConfigurationManager.AppSettings.Get("EnableSSL").ToUpper() == "YES")
            {
                bEnableSSL = true;
            }
            else
            {
                bEnableSSL = false;
            }
        }

        public void SendMail(string messageId, string toAddress, string[] param)
        {
            XmlDocument xdoc = new XmlDocument();
            string mailFormatxml = HttpContext.Current.Server.MapPath("\\") + "Mailformat.xml";
            string subject = "";
            string body = "";
            XmlNode mailNode = default(XmlNode);
            int n = 0;

            if ((System.IO.File.Exists(mailFormatxml)))
            {
                xdoc.Load(mailFormatxml);
                mailNode = xdoc.SelectSingleNode("MailFormats/MailFormat[@Id='" + messageId + "']");
                subject = mailNode.SelectSingleNode("Subject").InnerText;
                body = mailNode.SelectSingleNode("Body").InnerText;
                if ((param == null))
                {
                    throw new Exception("Mail format file not found.");
                }
                else
                {
                    // for (n = 0; n <= param.length="" -="" 1;="" n++)="" {="" body="body.Replace(n.ToString()" +="" "?",="" param[n]);="" subject="subject.Replace(n.ToString()" +="" "?",="" param[n]);="" }="" }="" initmail();="" dynamic="" mailmessage="new" mailmessage();="" mailmessage.from="new" mailaddress(fromaddress);="" mailmessage.to.add(strtoaddress);="" mailmessage.subject="subject;" mailmessage.isbodyhtml="true;" mailmessage.body="body;" mailmessage.replyto="new" mailaddress(fromaddress);="" smtpclient="" smtpclient="new" smtpclient();="" smtpclient.host="strSmtpClient;" smtpclient.enablessl="bEnableSSL;" smtpclient.port="Convert.ToInt32(SMTPPort);" smtpclient.credentials="new" system.net.networkcredential(userid,="" password);="" try="" {="" smtpclient.send(mailmessage);="" }="" catch="" (smtpfailedrecipientsexception="" ex)="" {="" for="" (int="" i="0;" i=""><= ex.innerexceptions.length;="" i++)="" {="" smtpstatuscode="" status="ex.InnerExceptions[i].StatusCode;" if="" ((status="=" smtpstatuscode.mailboxbusy)="" |="" (status="=" smtpstatuscode.mailboxunavailable))="" {="" system.threading.thread.sleep(5000);="" smtpclient.send(mailmessage);="" }="" }="" }="" }="" }="" }="" }="">
                }

            }

        }
    }
}
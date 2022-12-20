using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using System.Net.Http;

namespace Ruokalistat.tk.Special
{
    public class Mail : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string body)
        {
            //TODO: Mailkitti
        }
    }
}

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class Program
    {
        static void Main(string[] args)
        {

            MailHandler mailHandler = new MailHandler();
            IList<Label> Labels = mailHandler.GetLabels();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SendingEmail.UsersСlasses;

namespace WindowsFormsApp1.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) :
            base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("manukyan_artur_1994@bk.ru", "Манукян Артур, Остапчук Антон, Королев Никита");
            EmailPassword = "imMiQNjW41DNajQ0QYbc";
            Port = -1;
        }
    }
}

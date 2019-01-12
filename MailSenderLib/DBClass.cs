using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    public class DBClass
    {
        private readonly RecepientsDataContext _Rcepients = new RecepientsDataContext();
        public IQueryable<Recepient> Recepients => _Rcepients.Recepient;
    }
}

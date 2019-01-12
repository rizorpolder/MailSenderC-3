using System.Collections.ObjectModel;
using System.Linq;

namespace MailSenderLib
{
    public class DataAccessSercviceFromDB : IDataAccessSevice
    {
        private RecepientsDataContext _DatabaseContext;

        public DataAccessSercviceFromDB()
        {
            _DatabaseContext = new RecepientsDataContext();
        }

        public ObservableCollection<Recepient> GetRecepients()
        {
            return new ObservableCollection<Recepient>(_DatabaseContext.Recepient.ToArray());
        }
    }
}

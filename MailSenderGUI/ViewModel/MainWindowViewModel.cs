using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MailSenderLib;

namespace MailSenderGUI.ViewModel
{
   public class MainWindowViewModel:ViewModelBase
   {

       private readonly IDataAccessSevice _dataAccessSevice;
       private string _title = "Заголовок";

       public string Title
       {
           get => _title;
           set => Set(ref _title, value);
       }


       public ObservableCollection<Recepient> Recepients { get; private set; }

       public MainWindowViewModel(IDataAccessSevice DataAccessServise)
       {
           _dataAccessSevice = DataAccessServise;
           Recepients = _dataAccessSevice.GetRecepients();
       }

    }
}

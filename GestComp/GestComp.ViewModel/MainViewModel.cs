using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestComp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public const string MailPropertyName = "Mail";
        public const string PasswordPropertyName = "Password";

        private readonly INavigationService _navigationService;

        private string _mail;
        private string _password;
        private RelayCommand _navigateCommand;

        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {
                Set(MailPropertyName, ref _mail, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                Set(PasswordPropertyName, ref _password, value);
            }
        }

        public RelayCommand Connect
        {
            get
            {
                return _navigateCommand
                       ?? (_navigateCommand = new RelayCommand(
                           () => _navigationService.NavigateTo(ViewModelLocator.HomePageKey)));
            }
        }

        public MainViewModel(
            INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

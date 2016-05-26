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
    public class SettingViewModel : ViewModelBase
    {
        private RelayCommand _navigateCommand;

        private readonly INavigationService _navigationService;

        public SettingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public RelayCommand Back
        {
            get
            {
                return _navigateCommand = new RelayCommand(
                           () => _navigationService.NavigateTo(ViewModelLocator.HomePageKey));
            }
        }
    }
}

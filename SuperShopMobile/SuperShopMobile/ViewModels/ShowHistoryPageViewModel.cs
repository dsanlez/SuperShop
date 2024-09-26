using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShopMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SuperShopMobile.ViewModels
{
    public class ShowHistoryPageViewModel : ViewModelBase
    {
        public ShowHistoryPageViewModel(INavigationService navigationService) :base(navigationService)
        {
            Title = Languages.ShowPurchaseHistory;
        }
    }
}

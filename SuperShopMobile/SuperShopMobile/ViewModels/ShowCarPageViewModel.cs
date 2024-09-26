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
    public class ShowCarPageViewModel : ViewModelBase
    {
        public ShowCarPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ShowShoppingCart;
        }
    }
}

﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShopMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShopMobile.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.Modifyuser;
        }
    }
}

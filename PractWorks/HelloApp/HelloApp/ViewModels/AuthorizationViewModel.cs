using CommunityToolkit.Mvvm.ComponentModel;
using HelloApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp.ViewModels
{
    public partial class AuthorizationViewModel : ViewModelBase
    {
        [ObservableProperty]
        private UserCreditionals creditionals = new();


        private readonly NavigationService _navigation;

    }
}

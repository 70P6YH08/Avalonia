using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp.ViewModels
{
    public partial class RegistrationViewModel : ViewModelBase
    {
        [ObservableProperty]
        private UserCreditionals creditionals = new();
    }
}

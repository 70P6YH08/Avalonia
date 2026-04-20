using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pract1.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string text = "Hello Kim";

        [RelayCommand]
        private void ChangeText()
        {
            Text = "Hello Slava";
        }
    }
}

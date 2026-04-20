using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloApp.Views;

namespace HelloApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase currentPage = new AuthorizationViewModel();

        [RelayCommand]
        private void Auth()
        {
            CurrentPage = new AuthorizationViewModel();
        }

        [RelayCommand]

        private void Reg()
        {
            CurrentPage = new RegistrationViewModel();
        }
    }
}

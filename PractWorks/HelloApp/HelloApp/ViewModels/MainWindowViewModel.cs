using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloApp.Services;
using HelloApp.Views;

namespace HelloApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public static NavigationService Navigation { get; set; } = new();

        [RelayCommand]
        private void GoBack()
        {
            Navigation.GoBack();
        }

        [RelayCommand]
        private void Auth()
        {
            Navigation.NavigateTo(new AuthorizationViewModel());
        }

        [RelayCommand]
        private void Reg()
        {
            Navigation.NavigateTo(new RegistrationViewModel());
        }
    }
}

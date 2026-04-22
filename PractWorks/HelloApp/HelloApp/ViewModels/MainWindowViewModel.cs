using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloApp.Services;
using HelloApp.Views;

namespace HelloApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string key = App.Configuration.GetSection("ApiKeys")["SomeApi"];

        public static NavigationService Navigation { get; set; } = new();


        [RelayCommand]
        private void GoBack()
        {
            Navigation.GoBack();
        }

        [RelayCommand]
        private void Auth()
        {
            Navigation.NavigateTo<AuthorizationViewModel>();
        }

        [RelayCommand]
        private void Reg()
        {
            Navigation.NavigateTo<RegistrationViewModel>();
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace PractWork7.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly UserService _userService;

        [ObservableProperty]
        private int id = 0;

        [ObservableProperty]
        private string _login = "";

        [ObservableProperty]
        private string _password = "";

        [ObservableProperty]
        private ObservableCollection<User> _users = new();

        public MainWindowViewModel()
        {
            _userService = new UserService(new AppDbContext());
            Users = new ObservableCollection<User>(_userService.GetAllUsers());
        }

        [RelayCommand]
        private void AddUser()
        {
            var user = new User { Login = Login, Password = Password };
            _userService.AddUser(user);
            Users.Add(user);
            Login = Password = "";
        }

        [RelayCommand]
        private void DeleteUser(User user)
        {
            _userService.DeleteUser(user.Id);
            Users.Remove(user);
        }

        [RelayCommand]
        private void SaveUser()
        {
            _userService.SaveUser();
        }


        [RelayCommand]
        private void UpdateUser(User user)
        {
            user.Login = Login;
            user.Password = Password;
            _userService.UpdateUser(user);

            Users = new ObservableCollection<User>(_userService.GetAllUsers());
        }
    }
}

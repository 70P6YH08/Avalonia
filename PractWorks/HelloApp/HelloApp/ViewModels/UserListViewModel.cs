using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloApp.ViewModels
{
    public partial class UserListViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<User> users = new ObservableCollection<User> {
            new User{Login = "qwe", Password = "123"},
            new User{Login = "Kolya", Password = "228"},
            new User{Login = "gek", Password = "luk"},
            new User{Login = "login", Password = "password"},
            new User{Login = "ewq", Password = "321"},
            new User{Login = "asd", Password = "456"},
            new User{Login = "654", Password = "dsa"},
            new User{Login = "kovichka", Password = "44444"},
            new User{Login = "string", Password = "stringi"},
            new User{Login = "int", Password = "integer"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
            new User{Login = "gymbro", Password = "petux"},
        };

        [ObservableProperty]
        private string login;
        [ObservableProperty]
        private string password;

        [RelayCommand]
        private void DeleteUser(User user)
        {
            Users.Remove(user);
        }

        [RelayCommand]
        private void AddUser()
        {
            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                Users.Add(new User { Login = Login, Password = Password });
                Login = "";
                Password = "";
            }
        }
    }
}

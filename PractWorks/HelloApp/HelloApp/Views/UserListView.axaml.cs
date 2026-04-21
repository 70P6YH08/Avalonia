using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class UserListView : UserControl
{
    public UserListView()
    {
        InitializeComponent();
        DataContext = new UserListViewModel();
    }
}
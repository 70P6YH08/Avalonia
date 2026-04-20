using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
        DataContext = new HomeViewModel();
    }
}
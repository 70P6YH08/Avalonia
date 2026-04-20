using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Pract1.ViewModels;

namespace Pract1.Views;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
        DataContext = new HomeViewModel();
    }
}
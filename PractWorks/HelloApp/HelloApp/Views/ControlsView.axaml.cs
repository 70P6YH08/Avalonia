using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class ControlsView : UserControl
{
    public ControlsView()
    {
        InitializeComponent();
        DataContext = new ControlsViewModel();
    }
}
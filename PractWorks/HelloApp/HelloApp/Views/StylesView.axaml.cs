using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class StylesView : UserControl
{
    public StylesView()
    {
        InitializeComponent();
        DataContext = new StylesViewModel();
    }
}
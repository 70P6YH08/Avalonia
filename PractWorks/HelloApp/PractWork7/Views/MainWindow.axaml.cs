using Avalonia.Controls;
using PractWork7.ViewModels;

namespace PractWork7.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using var db = new AppDbContext();
            db.Database.EnsureCreated();
        }
    }
}
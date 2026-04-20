using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloApp.ViewModels
{
    public partial class ControlsViewModel : ViewModelBase
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Age))]
        private DateTime selectedDate = new DateTime(2000,1,1);

        public int Age => DateTime.Today.Year - SelectedDate.Year;

        public ObservableCollection<string> Languages { get; } = new() {
            "C#",
            "Java",
            "Kotlin",
            "Python"
        };

        [ObservableProperty]
        private string selectedLanguage;


        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Opacity))]
        private double selectedSliderValue = 0.0;

        public double Opacity => SelectedSliderValue;
    }
}

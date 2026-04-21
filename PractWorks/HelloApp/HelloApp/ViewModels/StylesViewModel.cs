using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloApp.ViewModels
{
    public partial class StylesViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<MoneyOperation> moneyOperations = new ObservableCollection<MoneyOperation> {
            new MoneyOperation{Description = "gymbro", Sum = "petux", IsIncome = true},
            new MoneyOperation{Description = "123", Sum = "asd", IsIncome = false},
            new MoneyOperation{Description = "zxc", Sum = "qwe", IsIncome = true},
            new MoneyOperation{Description = "gymbro", Sum = "petux", IsIncome = true},
            new MoneyOperation{Description = "ega", Sum = "ega", IsIncome = false},
            new MoneyOperation{Description = "ega", Sum = "petux", IsIncome = false},
            new MoneyOperation{Description = "gymbro", Sum = "ega", IsIncome = false},
            new MoneyOperation{Description = "lev", Sum = "krut", IsIncome = true},
            new MoneyOperation{Description = "ega", Sum = "petux", IsIncome = false},
            new MoneyOperation{Description = "money", Sum = "petux", IsIncome = true},
            new MoneyOperation{Description = "gymbro", Sum = "money_petyxa", IsIncome = false},
            new MoneyOperation{Description = "pen", Sum = "pen_of_petux", IsIncome = true},
            new MoneyOperation{Description = "desktop", Sum = "summa", IsIncome = true},
            new MoneyOperation{Description = "kolya", Sum = "petya", IsIncome = false},
            new MoneyOperation{Description = "petya", Sum = "general", IsIncome = true},
            new MoneyOperation{Description = "kazakov", Sum = "666_diavol_9999", IsIncome = false},
            new MoneyOperation{Description = "lu4kov", Sum = "pro100jiriikiller", IsIncome = false},
            new MoneyOperation{Description = "taburetka", Sum = "petux", IsIncome = true},
            new MoneyOperation{Description = "nosatii", Sum = "jitel_in_your ass", IsIncome = true},
            new MoneyOperation{Description = "prisch", Sum = "egora", IsIncome = true},
            new MoneyOperation{Description = "moneymoneymoney", Sum = "petuxpetuxpetux", IsIncome = false}
        };
    }
}

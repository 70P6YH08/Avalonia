using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloApp.ViewModels
{
    public class MoneyOperation
    {
        public string Description { get; set; }
        public string Sum { get; set; }
        public bool IsIncome { get; set; } = false;
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelloApp.ViewModels
{

    public partial class UserCreditionals : ObservableValidator
    {
        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required(ErrorMessage = "Логин не может быть пуст")]
        [MinLength(3, ErrorMessage = "Минимальная длина 3 символа")]
        [MaxLength(20, ErrorMessage = "Максимальная длина 20 символов")]
        [RegularExpression("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*_)([a-zA-Z0-9_]).*$", ErrorMessage = "Логин должен включать в себя цифры, латинские буквы и нижнее подчёркивание")]
        private string login = "";

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [MinLength(8, ErrorMessage = "Минимальная длина 8 символов")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_\\-]).*$", ErrorMessage = "Пароль должен включать в себя большие и маленькие латинские буквы и спецсимволы")]
        private string password = "";

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [MinLength(8, ErrorMessage = "Минимальная длина 8 символов")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_\\-]).*$", ErrorMessage = "Пароль должен включать в себя большие и маленькие латинские буквы и спецсимволы")]
        private string repeatPassword = "";

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [RegularExpression("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}", ErrorMessage = "Не правильный формат почты")]
        private string email = "";

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [RegularExpression("\\+7{1}9{1}\\d{9}|8{1}9{1}\\d{9}", ErrorMessage = "Не правильный формат номера")]
        private string phone = "";
    }
}

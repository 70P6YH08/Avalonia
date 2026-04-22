using CommunityToolkit.Mvvm.ComponentModel;
using HelloApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HelloApp.Services
{
    public partial class NavigationService : ViewModelBase
    {
        private Stack<ViewModelBase> stack = new();

        [ObservableProperty]
        public ViewModelBase currentViewModel = new AuthorizationViewModel();

        public void NavigateTo<T>(T viewModel, Action<T>? action = null) where T : ViewModelBase
        {
            action?.Invoke(viewModel);
            stack.Push(viewModel);
            CurrentViewModel = viewModel;
        }

        public void GoBack()
        {
            for (int i = 0; i < 1 && stack.Count > 1; i++)
                stack.Pop();
            if (stack.Count > 0)
                CurrentViewModel = stack.Peek();
        }

        public void NavigateTo<T>(Action<T>? action = null) where T : ViewModelBase
        {
            var viewModel = App.Services.GetRequiredService<T>();
            NavigateTo(viewModel, action);
        }

    }
}

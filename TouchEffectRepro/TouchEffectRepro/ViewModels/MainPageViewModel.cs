using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouchEffectRepro.Views;

namespace TouchEffectRepro.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool can_click = true;

        public DelegateCommand Command_Click => new DelegateCommand(Click).ObservesCanExecute(() => can_click);
        
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private async void Click()
        {
            //if (!can_click) return;

            can_click = false;
            await NavigationService.NavigateAsync(nameof(Page1), useModalNavigation:true);
            can_click = true;
        }
    }
}

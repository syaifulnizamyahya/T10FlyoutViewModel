using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Template10.Behaviors;

namespace T10FlyoutViewModel.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        bool _IsFlyoutOpen = default(bool);
        public bool IsFlyoutOpen
        {
            get { return _IsFlyoutOpen; }
            set
            {
                var ofa = new OpenFlyoutAction();
                if (_IsFlyoutOpen)
                {
                    // what should i call here to open flyout
                }
                else
                {
                    // what should i call here to close flyout
                }
                Set(ref _IsFlyoutOpen, value);
            }
        }


        DelegateCommand _CloseFlyout;
        public DelegateCommand CloseFlyout
           => _CloseFlyout ?? (_CloseFlyout = new DelegateCommand(() =>
           {
               _IsFlyoutOpen = false;
           }, () => true));


        DelegateCommand _OpenFlyout;
        public DelegateCommand OpenFlyout
           => _OpenFlyout ?? (_OpenFlyout = new DelegateCommand(() =>
           {
               _IsFlyoutOpen = true;
           }, () => true));
    }
}

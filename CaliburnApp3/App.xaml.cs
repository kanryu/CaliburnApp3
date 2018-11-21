using Caliburn.Micro;
using CaliburnApp3.ViewModels;
using CaliburnApp3.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CaliburnApp3
{
    public sealed partial class App
    {
        private WinRTContainer container;

        public App()
        {
            InitializeComponent();
        }

        protected override void Configure()
        {
            container = new WinRTContainer();
            container.RegisterWinRTServices();

            container
                .PerRequest<PageViewModel>()
                .PerRequest<Page2ViewModel>()
            ;
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            var navigationService = container.RegisterNavigationService(rootFrame);
            var navigationManager = SystemNavigationManager.GetForCurrentView();

            navigationService.Navigated += (s, e) =>
            {
                navigationManager.AppViewBackButtonVisibility = navigationService.CanGoBack ?
                    AppViewBackButtonVisibility.Visible :
                    AppViewBackButtonVisibility.Collapsed;
            };
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                return;

            DisplayRootView<PageView>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        protected override async void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            e.Handled = true;

            var dialog = new MessageDialog(e.Message, "An error has occurred");

            await dialog.ShowAsync();
        }
    }
}

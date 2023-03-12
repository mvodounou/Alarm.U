using System;
using Alarm.u.ViewModels;
using Alarm.u.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alarm.u
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            SetUpSyncFusion();
            InitializeComponent();
            NavigationService.NavigateAsync(nameof(Main));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Main, MainViewModel>();
        }

        private void SetUpSyncFusion()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("MTMwMzUwNUAzMjMwMmUzNDJlMzBpTjR5TjBxWFVua3duLy9LbnJSMm1NMURhZ0hLRmhrWnIwQ2JsOFdlaWpZPQ==");
        }
    }
}


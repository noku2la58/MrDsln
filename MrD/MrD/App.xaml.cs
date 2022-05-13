using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var narPage = new NavigationPage(new MainPage());
            MainPage = narPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

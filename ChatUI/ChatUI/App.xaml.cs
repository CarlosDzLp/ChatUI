using System;
using ChatUI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ChatPage());
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
